/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio.MySQL;

import java.io.FileInputStream;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Properties;

/**
 *
 * @author Usuario
 */
public class MySql {

    protected Statement st;
    protected ResultSet rs;
    protected String strSQL;

    public MySql() {
       
        st = Conexion.getInstancia().getStatement();
    }

    public void seleccionar(String filtro) {
        try {
            rs = st.executeQuery(filtro);
        } catch (SQLException ex) {
            System.err.println("SQLException: " + ex.getMessage());
        }
    }

    public void update(String strSQL) {
        try {
            System.out.println(strSQL);
            st.executeUpdate(strSQL);
           
        } catch (SQLException ex) {
            System.err.println("SQLException: " + ex.getMessage());
        }
    }

    public void query(String strSQL) {
        try {
            System.out.println(strSQL);
            st.executeQuery(strSQL);
            rs.close();
        } catch (SQLException ex) {
            System.err.println("SQLException: " + ex.getMessage());
        }
    }

  
}
