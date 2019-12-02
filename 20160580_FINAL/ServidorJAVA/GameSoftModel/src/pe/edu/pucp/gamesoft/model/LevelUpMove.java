package pe.edu.pucp.gamesoft.model;

import java.io.Serializable;

public class LevelUpMove implements Serializable{
    private int idLevelUpMove;
    private int levelOfLearning;
    private String moveName;
    private Type type;
    private Kind kind;
    private int power;
    private int accuracy;
    private int powerPoint;
    private Range range;

    public LevelUpMove(){
        this.type = new Type();
        this.kind = new Kind();
        this.range = new Range();
    }
    
    public int getIdLevelUpMove() {
        return idLevelUpMove;
    }

    public void setIdLevelUpMove(int idLevelUpMove) {
        this.idLevelUpMove = idLevelUpMove;
    }

    public int getLevelOfLearning() {
        return levelOfLearning;
    }

    public void setLevelOfLearning(int levelOfLearning) {
        this.levelOfLearning = levelOfLearning;
    }

    public String getMoveName() {
        return moveName;
    }

    public void setMoveName(String moveName) {
        this.moveName = moveName;
    }

    public Type getType() {
        return type;
    }

    public void setType(Type type) {
        this.type = type;
    }

    public Kind getKind() {
        return kind;
    }

    public void setKind(Kind kind) {
        this.kind = kind;
    }

    public int getPower() {
        return power;
    }

    public void setPower(int power) {
        this.power = power;
    }

    public int getAccuracy() {
        return accuracy;
    }

    public void setAccuracy(int accuracy) {
        this.accuracy = accuracy;
    }

    public int getPowerPoint() {
        return powerPoint;
    }

    public void setPowerPoint(int powerPoint) {
        this.powerPoint = powerPoint;
    }

    public Range getRange() {
        return range;
    }

    public void setRange(Range range) {
        this.range = range;
    }
    
    
}
