/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Dominio;

/**
 *
 * @author Usuario
 */
public class Registro {
 
    private int id;
    private String departamento;
    private String tipo_precipitacion;
    private int dia;
    private int mes;
    private int año;
    private int hora;
    private int minutos;
    private double precipitacion;
    private double temperatura;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getDepartamento() {
        return departamento;
    }

    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    }

    public String getTipo_precipitacion() {
        return tipo_precipitacion;
    }

    public void setTipo_precipitacion(String tipo_presipitacion) {
        this.tipo_precipitacion = tipo_presipitacion;
    }

    public int getDia() {
        return dia;
    }

    public void setDia(int dia) {
        this.dia = dia;
    }
    
    public int getMes() {
        return mes;
    }

    public void setMes(int mes) {
        this.mes = mes;
    }
    
    public int getAño() {
        return año;
    }

    public void setAño(int año) {
        this.año = año;
    }

    public int getHora() {
        return hora;
    }

    public void setHora(int hora) {
        this.hora = hora;
    }
    
    public int getMinutos() {
        return minutos;
    }

    public void setMinutos(int minutos) {
        this.minutos = minutos;
    }

    public double getPrecipitacion() {
        return precipitacion;
    }

    public void setPrecipitacion(double precipitacion) {
        this.precipitacion = precipitacion;
    }

    public double getTemperatura() {
        return temperatura;
    }

    public void setTemperatura(double temperatura) {
        this.temperatura = temperatura;
    }

    public Registro() {
    }

    public Registro(int id, String departamento, String tipo_presipitacion, int dia, int mes, int año, int hora, int minutos, double precipitacion, double temperatura) {
        this.id = id;
        this.departamento = departamento;
        this.tipo_precipitacion = tipo_presipitacion;
        this.dia = dia;
        this.mes = mes;
        this.año =año;
        this.hora = hora;
        this.minutos = minutos;
        this.precipitacion = precipitacion;
        this.temperatura = temperatura;
    }

    @Override
    public String toString() {
        return "Registro{" + "id: " + id + ", Departamento:" + departamento + ", Tipo de precipitación:" + tipo_precipitacion + ", Fecha:" + año + "/" + mes + "/" + dia + ", Hora: " + hora + ":" + minutos + ", Precipitación:" + precipitacion + ", Temperatura:" + temperatura + '}';
    }
    
    
    
}
