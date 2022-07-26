/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio.MySQL;

import Dominio.Registro;
import Servicio.IRegistro;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author nicolas
 */
public class RegistroMySql extends MySql implements IRegistro {

    @Override
    public void Guardar(Registro r) {
        strSQL = "INSERT INTO registro(id, departamento, tipo_precipitacion, dia, mes, año, hora, minutos, precipitacion, temperatura) VALUES ('" + r.getId() + "','" + r.getDepartamento() + "','" + r.getTipo_precipitacion() + "','" + r.getDia() + "','" + r.getMes() + "','" + r.getAño() + "','" + r.getHora() + "','" + r.getMinutos()+ "','" + r.getPrecipitacion() + "','" + r.getTemperatura() + "')";
        update(strSQL);
    }

    @Override
    public boolean Borrar(int id) {
        strSQL = "DELETE FROM registro WHERE id = " + id;
        update(strSQL);
        return true;
    }

    @Override
    public Registro Buscar(int id) {
        return null;
    }

    @Override
    public List<Registro> Registros() {
        List<Registro> registros = new ArrayList<Registro>();
        Registro r = null;
        this.seleccionar("SELECT * FROM registro");
        try {
            while (rs.next()) {
                r = new Registro(rs.getInt("id"),
                        rs.getString("Departamento"),
                        rs.getString("tipo_precipitacion"),
                        rs.getInt("dia"),
                        rs.getInt("mes"),
                        rs.getInt("año"),
                        rs.getInt("hora"),
                        rs.getInt("minutos"),
                        rs.getDouble("precipitacion"),
                        rs.getDouble("temperatura"));
                registros.add(r);
            }
            rs.close();
        } catch (SQLException ex) {
            System.err.println("SQLException: " + ex.getMessage());
        }
        return registros;
    }

    @Override
    public void Modificar(Registro r) {
        strSQL = "UPDATE registro SET departamento='" + r.getDepartamento() + "', tipo_precipitacion ='" + r.getTipo_precipitacion() + "', dia ='" + r.getDia() + "', mes ='" + r.getMes() + "', año ='" + r.getAño() + "', hora ='" + r.getHora() + "', minutos ='" + r.getMinutos() + "', precipitacion ='" + r.getPrecipitacion() + "', temperatura ='" + r.getTemperatura() + "' WHERE id=" + r.getId();
        update(strSQL);
    }

}
