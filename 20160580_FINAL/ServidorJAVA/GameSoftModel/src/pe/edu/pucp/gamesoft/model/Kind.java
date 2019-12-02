package pe.edu.pucp.gamesoft.model;

import java.io.Serializable;

public class Kind implements Serializable{
    private int idKind;
    private String movementKind;

    public Kind(){
        
    }
    
    public int getIdKind() {
        return idKind;
    }

    public void setIdKind(int idKind) {
        this.idKind = idKind;
    }

    public String getMovementKind() {
        return movementKind;
    }

    public void setMovementKind(String movementKind) {
        this.movementKind = movementKind;
    }
    
    
}
