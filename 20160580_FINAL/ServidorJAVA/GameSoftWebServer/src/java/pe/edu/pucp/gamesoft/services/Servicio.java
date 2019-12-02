package pe.edu.pucp.gamesoft.services;

import java.rmi.RemoteException;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.gamesoft.dao.*;
import pe.edu.pucp.gamesoft.model.*;

@WebService(serviceName = "Servicio")
public class Servicio {

    //Declarar los DAOS (las interfaces)
    
    private PokemonDAO pokemonDAO;
    private KindDAO kindDAO;
    private RangeDAO rangeDAO;
    private TypeDAO typeDAO;
    
    public Servicio(){
        try {
            System.setProperty("java.rmi.server.hostname", "127.0.0.1");
            //Inicializar las interfaces como cliente RMI
            pokemonDAO = (PokemonDAO) java.rmi.Naming.lookup("//127.0.0.1:1234/pokemonDAO");
            kindDAO = (KindDAO) java.rmi.Naming.lookup("//127.0.0.1:1234/kindDAO");
            rangeDAO = (RangeDAO) java.rmi.Naming.lookup("//127.0.0.1:1234/rangeDAO");
            typeDAO = (TypeDAO) java.rmi.Naming.lookup("//127.0.0.1:1234/typeDAO");
        } catch (Exception ex) {  
            System.out.println(ex.getMessage());
	}
    }
    
    /*Programar los servicios haciendo uso de las interfaces y ofrecerlos al cliente C#*/    
    
    @WebMethod(operationName = "listarTodasCategorias")
    public ArrayList<Kind> listarTodasCategorias() throws RemoteException{
        return this.kindDAO.queryAll();
    }
    
    @WebMethod(operationName = "listarTodosTipos")
    public ArrayList<Type> listarTodosTipos() throws RemoteException{
        return this.typeDAO.queryAll();
    }
    
    @WebMethod(operationName = "listarTodosRangos")
    public ArrayList<Range> listarTodosRangos() throws RemoteException{
        return this.rangeDAO.queryAll();
    }
    
    @WebMethod(operationName = "insertarPokemon")
    public int insertarPokemon(@WebParam(name = "pokemon")Pokemon pokemon) throws RemoteException{
        return this.pokemonDAO.insert(pokemon);
    }
    
    @WebMethod(operationName = "listarPokemons")
    public ArrayList<Pokemon> listarPokemons(@WebParam(name = "name")String name) throws RemoteException{
        return this.pokemonDAO.queryAll(name);
    }
    
    @WebMethod(operationName = "eliminarPokemon")
    public int eliminarPokemon(@WebParam(name = "idPokemon")int idPokemon) throws RemoteException{
        return this.pokemonDAO.delete(idPokemon);
    }
    
    @WebMethod(operationName = "modificarPokemon")
    public int modificarPokemon(@WebParam(name = "pokemon")Pokemon pokemon) throws RemoteException{
        return this.pokemonDAO.update(pokemon);
    }
}
