package generarpatrones;
import java.io.*;


public class GenerarPatrones {
    private int turnos;
    private int dias;
    private String nombre;
    private String todos;
    
    public GenerarPatrones(int turnos, int dias, String nombre){
        this.nombre = nombre;
        this.turnos=turnos;
        this.dias = dias;
        this.todos= "";
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
                wr.append(actual);
                //aqui vendria toda la logica que le queremos poner al programa
                //por ejemplo: cantidad de findes o domingo libre.
                
                wr.append(";"+getFindeSemanas(actual));
                bw.newLine();
            }
            else {
                for(int i=0; i<turnos; i++){
                    pasoRecursivo(avance-1,turnos,actual+","+i,wr,bw);
                }
            }
        }
        catch(Exception e){
            System.err.println(e);
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
}
