package pe.edu.pucp.gamesoft.server;

import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import pe.edu.pucp.gamesoft.config.DAOFactory;
import pe.edu.pucp.gamesoft.dao.*;
import pe.edu.pucp.gamesoft.mysql.*;

public class Program{    
    private static final String IP = "127.0.0.1";
    private static final int PORT = 1234; 
    
    public static void main(String[] args){
        try{
            System.setProperty("java.rmi.server.hostname", IP);
            LocateRegistry.createRegistry(PORT);
            
            PokemonDAO pokemonDAO = new PokemonMySQL();
            KindDAO kindDAO = new KindMySQL();
            RangeDAO rangeDAO = new RangeMySQL();
            TypeDAO typeDAO = new TypeMySQL();
            //Programar los Servicios RMI
            java.rmi.Naming.rebind("//127.0.0.1:1234/pokemonDAO", pokemonDAO);
            java.rmi.Naming.rebind("//127.0.0.1:1234/kindDAO", kindDAO);
            java.rmi.Naming.rebind("//127.0.0.1:1234/rangeDAO", rangeDAO);
            java.rmi.Naming.rebind("//127.0.0.1:1234/typeDAO", typeDAO);
            
            System.out.println("El servidor se encuentra a la espera de conexiones..");
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}