package generarpatrones;
import java.io.*;


public class GenerarPatrones {
    private int turnos;
    private int dias;
    private String todos;
    
    public GenerarPatrones(int turnos, int dias){
        this.turnos=turnos;
        this.dias = dias;
        //this.todos= generarPatrones(turnos, dias);
    }
    
    public String getTodos(){
        return this.todos;
    }
    
    public void generarPatrones(int turnos, int dias){
        String salida="";
        File f;
        f = new File("patrones.txt");
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
            
        }
    }
    
    public void pasoRecursivo(int avance, int turnos, String actual, PrintWriter wr, BufferedWriter bw){
        try{
            if(avance==1){
                wr.append(actual);
                bw.newLine();
            }
            else {
                for(int i=0; i<turnos; i++){
                    pasoRecursivo(avance-1,turnos,actual+","+i,wr,bw);
                }
            }
        }
        catch(Exception e){
        }
    }
    

    /*recorre todo el "archivo"
     */
    public String encontrarSecuencia(String secuencia){
        String salida="";
        String linea="";
        for(int i=0; i<(this.todos.length()/((2*this.dias))); i++){
            //int m= this.todos.length();
            int j= i*((2*this.dias));
            linea= this.todos.substring(j, j+2*(this.dias)-1);
            //System.out.println("::"+linea+"::");
            if(linea.indexOf(secuencia)!=-1){
                salida+= i+",";
            }
        }
        return salida;
    }
    
    public void eliminar(String []indices){
        String nuevo_todos="";
        int k= Integer.parseInt(indices[0]);
        for(int i=0; i<(this.todos.length()/((2*this.dias))); i++){
            int j= i*((2*this.dias));
            
            if(indices[k].compareTo(""+i)==0){
                if(k<indices.length-1){
                    k++;
                    continue;
                }
                else{
                    continue;
                }
            }

            else{
                nuevo_todos+=this.todos.substring(j, j+2*(this.dias));
            }
        }      
        this.todos=nuevo_todos;
    }
    
    
    public void eliminarLinea(String indice){
        String nuevo_todos="";
        for(int i=0; i<(this.todos.length()/((2*this.dias))); i++){
            int j= i*((2*this.dias));
            if(indice.compareTo(""+i)!=0){
                nuevo_todos+=this.todos.substring(j, j+2*(this.dias));
            }
        }
        
        this.todos= nuevo_todos;
    }
    
}
