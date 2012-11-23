package generarpatrones;


public class GenerarPatrones {
    private int turnos;
    private int dias;
    private String todos;
    
    public GenerarPatrones(int turnos, int dias){
        this.turnos=turnos;
        this.dias = dias;
        this.todos= generarPatrones(turnos, dias);
    }
    
    public String getTodos(){
        return this.todos;
    }
    
    public String generarPatrones(int turnos, int dias){
        String salida="";
        for(int i=0; i<turnos; i++){
                salida+=(pasoRecursivo(dias,turnos, ""+i));
            }
        return salida;
    }
    
    public String pasoRecursivo(int avance, int turnos, String actual){
        String resultado="";
        if(avance==1){
            return actual+"\n";
        }
        else {
            for(int i=0; i<turnos; i++){
                resultado+=(pasoRecursivo(avance-1,turnos,actual+","+i));
            }
            return resultado;
        }
    }
    
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
