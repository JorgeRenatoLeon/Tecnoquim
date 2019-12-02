<%-- 
    Document   : newjsp
    Created on : 01/12/2019, 07:28:06 PM
    Author     : Freddy
--%>
<%@page import="pe.edu.pucp.gamesoft.dao.PokemonDAO"%>
<%@page import="java.util.ArrayList"%>
<%@page import="pe.edu.pucp.gamesoft.model.Pokemon"%>
<%
    System.setProperty("java.rmi.server.hostname", "127.0.0.1");
    ArrayList<Pokemon> pokemons;
    //Obtener el servicio PokemonDAO del servidor RMI y obtener la lista en el objeto pokemons
    PokemonDAO pokemonDAO = (PokemonDAO) java.rmi.Naming.lookup("//127.0.0.1:1234/pokemonDAO");
    pokemons = pokemonDAO.queryAll("");
%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="main.css" rel="stylesheet" type="text/css">
        <title>Listar Pokemons</title>
    </head>
    <body>
        <h1>Lista de Pokemons</h1>
        <form action="Prueba" method="get">
            <table style="border:1px solid black;">
                <tr>
                    <th>Id del Pokemon</th>
                    <th>Nro. Pokedex</th>
                    <th>Nombre del Pokemon</th>
                    <th>Tipo 1</th>
                    <th>Tipo 2</th>
                    <th></th>
                </tr>
                <% for(int i=0; i<pokemons.size(); i++){ %>
                <tr>
                    <td><label name="idPokemon"><%= pokemons.get(i).getIdPokemon() %></label></td>
                    <td > <%= pokemons.get(i).getNationalDexNumber() %></td>
                    <td > <%= pokemons.get(i).getName() %></td>
                    <td > <%= pokemons.get(i).getType1().getName() %></td>
                    <td > <%= pokemons.get(i).getType2().getName() %></td>
                    <td>
                        <input name="idPokemon" type="submit" value="<%= pokemons.get(i).getIdPokemon() %>"/>
                    </td>
                </tr>
                <%}%>
            </table>
        </form>
    </body>
</html>
