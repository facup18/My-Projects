/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio.MySQL;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;
/**
 *
 * @author Usuario
 */
public class Conexion {
    private static Conexion instancia = null;
    public static String ruta=null;
    private Connection con;

    private Conexion() {
        // cargar el driver que vamos a utilizar
        try {
            //Class.forName("com.mysql.jdbc.Driver").newInstance();
            Class.forName("com.mysql.jdbc.Driver");
            con = DriverManager.getConnection("jdbc:mysql://localhost/sistemameteorologico?user=root&password=root");
           
        } catch (ClassNotFoundException e) {
            System.err.print("ClassNotFoundException: ");
            System.err.println(e.getMessage());
        } catch (SQLException ex) {
            System.err.println("SQLException: " + ex.getMessage());
            JOptionPane.showMessageDialog(null, "SQLException: " + ex.getMessage(), "Error", 0);
        }
    }

    public static Conexion getInstancia() {
        if (instancia == null) {
            instancia = new Conexion();
        }
        return instancia;
    }

    public Statement getStatement() {
        Statement st = null;
        // crear un objeto Statement
        try {
            st = con.createStatement();
        } catch (SQLException ex) {
            System.err.println("SQLException: " + ex.getMessage());
        }
        return st;
    }

    @Override
    public void finalize() {
        try {
            con.close();
        } catch (SQLException ex) {
            System.err.println("SQLException: " + ex.getMessage());
        }
    }
}
