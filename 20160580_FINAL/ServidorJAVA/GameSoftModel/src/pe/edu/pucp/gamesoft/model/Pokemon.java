package pe.edu.pucp.gamesoft.model;

import java.io.Serializable;
import java.util.ArrayList;

public class Pokemon implements Serializable{
    private int idPokemon;
    private String name;
    private String nationalDexNumber;
    private Type type1;
    private Type type2;
    private double height;
    private double weight;
    private String description;
    private byte[] photo;
    private ArrayList<LevelUpMove> levelUpMoves;
    private boolean activo;

    public Pokemon(){
        this.type1 = new Type();
        this.type2 = new Type();
        this.levelUpMoves = new ArrayList<>();
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public ArrayList<LevelUpMove> getLevelUpMoves() {
        return levelUpMoves;
    }

    public void setLevelUpMoves(ArrayList<LevelUpMove> levelUpMoves) {
        this.levelUpMoves = levelUpMoves;
    }
    
    public int getIdPokemon() {
        return idPokemon;
    }

    public void setIdPokemon(int idPokemon) {
        this.idPokemon = idPokemon;
    }

    public String getNationalDexNumber() {
        return nationalDexNumber;
    }

    public void setNationalDexNumber(String nationalDexNumber) {
        this.nationalDexNumber = nationalDexNumber;
    }

    public Type getType1() {
        return type1;
    }

    public void setType1(Type type1) {
        this.type1 = type1;
    }

    public Type getType2() {
        return type2;
    }

    public void setType2(Type type2) {
        this.type2 = type2;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public byte[] getPhoto() {
        return photo;
    }

    public void setPhoto(byte[] photo) {
        this.photo = photo;
    }
    
}
