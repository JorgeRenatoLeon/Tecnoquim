package pe.edu.pucp.gamesoft.model;

import java.io.Serializable;

public class Range implements Serializable{
    private int idRange;
    private String movementRange;

    public Range() {
    }

    
    public int getIdRange() {
        return idRange;
    }

    public void setIdRange(int idRange) {
        this.idRange = idRange;
    }

    public String getMovementRange() {
        return movementRange;
    }

    public void setMovementRange(String movementRange) {
        this.movementRange = movementRange;
    }
    
}
