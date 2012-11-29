package generarpatrones;
import java.io.*;


public class GenerarPatrones {
    private int turnos;
    private int dias;
    private String noche;
    private String nombre;
    private String todos;
    
    public GenerarPatrones(int turnos, int dias){
        this.nombre = turnos+"x"+dias;
        this.turnos=turnos;
        this.dias = dias;
        this.noche= ""+(turnos-2);
        generarPatrones(turnos, dias);
    }
    
    public String getTodos(){
        return this.todos;
    }
    
    public void generarPatrones(int turnos, int dias){
        File f;
        String filename= this.nombre+".txt";
        f = new File(filename);
        try{
            FileWriter w = new FileWriter(f);
            BufferedWriter bw = new BufferedWriter(w);
            PrintWriter wr = new PrintWriter(bw);
            
            for(int i=0; i<turnos; i++){
                    pasoRecursivo(dias,turnos, ""+i,wr, bw);
                }
            wr.close();
            bw.close();
        }
        catch(Exception e){
            System.err.println(e);
        }
    }
    
    
    public void pasoRecursivo(int avance, int turnos, String actual, 
            PrintWriter wr, BufferedWriter bw){
        try{
            if(avance==1){
                if( revisarDiasLibres(actual, 2) && revisarSalientes(actual)
                        && revisarSeparacionDeTurnos(actual)) {
                    wr.append(actual);
                
                    wr.append(";"+getFindeSemanas(actual));
                    bw.newLine();
                }
                else
                    return;
                
            }
            else {
                for(int i=0; i<turnos; i++){
                    pasoRecursivo(avance-1,turnos,actual+","+i,wr,bw);
                }
            }
        }
        catch(Exception e){
            System.err.println("Error:"+e);
        }
    }
    

    /*recorre todo el "archivo"
     */
    public String getFindeSemanas(String semana){
        String resultado="0";
        if( semana.substring(semana.length()-3).compareTo("0,0")==0 ){
            return "1";
        }
        return resultado;
    }
     
    public boolean revisarDiasLibres(String actual, int num){
        String dias[]=actual.split(",");
        int libres=0;
        for(int i=0; i<dias.length; i++){
            if(dias[i].compareTo("0")==0){
                libres++;
            }
        }
        if(libres<2){
            return false;
        }
                    
        return true;
    }
    
    public boolean revisarSalientes(String actual){
        if( actual.lastIndexOf(""+(this.turnos-1))==-1){//si no hay salientes
            return true;//cumple con la condicion
        }
        String dias[]= actual.split(",");
        for(int i=1; i<dias.length;i++){
            //si estoy en un saliente
            //y el dia anterior NO fue noche, entonces FAIL
            if(dias[i].compareTo(""+(this.turnos-1))==0 && dias[i-1].compareTo(this.noche)!=0){
                return false;
            }
        }
        
        return true;
    }
    
    public boolean revisarSeparacionDeTurnos(String actual){
        String []dias= actual.split(",");
        for(int i=0; i<dias.length-1; i++){
            if( Integer.parseInt(dias[i])>Integer.parseInt(dias[i+1]) 
                    && Integer.parseInt(dias[i+1])!=0){
                return false;
            }
        }
        return true;
    }
    
    public boolean avoid(String actual, String patron){
        return true;
    }   
}

