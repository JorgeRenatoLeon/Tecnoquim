package pe.edu.pucp.gamesoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.Pokemon;

public interface PokemonDAO extends java.rmi.Remote{
    ArrayList<Pokemon> queryAll(String name)throws java.rmi.RemoteException;
    int insert(Pokemon pokemon)throws java.rmi.RemoteException;
    int update(Pokemon pokemon)throws java.rmi.RemoteException;
    int delete(int idPokemon)throws java.rmi.RemoteException;
}
