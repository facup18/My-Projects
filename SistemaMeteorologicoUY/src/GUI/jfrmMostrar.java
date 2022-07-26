/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package GUI;
import Dominio.Registro;
import javax.swing.DefaultListModel;
import java.util.ArrayList;
import Servicio.Fachada;
import com.toedter.calendar.JDateChooser;
import java.util.Calendar;
/**
 *
 * @author Usuario
 */
public class jfrmMostrar extends javax.swing.JFrame {

    Fachada fachada;
    
    public jfrmMostrar() {
        initComponents();
        fachada = Fachada.getInstancia();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jbtnMostrarMaxMinPrecipitaciones = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jbtnMostrarPromMens = new javax.swing.JButton();
        jbtnMostrarMaxMinTemperatura = new javax.swing.JButton();
        jlblModificar = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jlstMostrar = new javax.swing.JList<String>();
        jCalendarAñoPromedioPrecipitacion = new com.toedter.calendar.JYearChooser();
        jCalendar = new com.toedter.calendar.JDateChooser();
        jCalendarAñoTemperaturaMinMax = new com.toedter.calendar.JYearChooser();
        volvermostrar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jbtnMostrarMaxMinPrecipitaciones.setText("Mostrar");
        jbtnMostrarMaxMinPrecipitaciones.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnMostrarMaxMinPrecipitacionesActionPerformed(evt);
            }
        });

        jLabel1.setText("Obtener Valores Maximos Y Minimos De Precipitaciones De Un Día Dado");

        jLabel2.setText("Obtener Promedio De Precipitaciones Mensuales En un Año Específico");

        jLabel3.setText("Mostrar La Temperatura Mínima Y Máxima A Nivel Nacional En Un Año Específico");

        jbtnMostrarPromMens.setText("Mostrar");
        jbtnMostrarPromMens.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnMostrarPromMensActionPerformed(evt);
            }
        });

        jbtnMostrarMaxMinTemperatura.setText("Mostrar");
        jbtnMostrarMaxMinTemperatura.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnMostrarMaxMinTemperaturaActionPerformed(evt);
            }
        });

        jlblModificar.setFont(new java.awt.Font("Gill Sans Ultra Bold", 0, 36)); // NOI18N
        jlblModificar.setText("Mostrar");

        jLabel4.setText("Ingresar Fecha:");

        jLabel5.setText("Ingresar Año:");

        jLabel6.setText("Ingresar Año:");

        jScrollPane2.setViewportView(jlstMostrar);

        volvermostrar.setText("Volver");
        volvermostrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                volvermostrarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel2)
                            .addComponent(jLabel1))
                        .addGap(29, 29, 29))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(jLabel3)
                        .addContainerGap())))
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(105, 105, 105)
                        .addComponent(jlblModificar)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(volvermostrar))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(89, 89, 89)
                                .addComponent(jLabel5)
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jbtnMostrarPromMens)
                                    .addComponent(jCalendarAñoPromedioPrecipitacion, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(92, 92, 92)
                                .addComponent(jLabel6)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jbtnMostrarMaxMinTemperatura)
                                    .addComponent(jCalendarAñoTemperaturaMinMax, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(93, 93, 93)
                        .addComponent(jLabel4)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jbtnMostrarMaxMinPrecipitaciones)
                            .addComponent(jCalendar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 370, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(0, 0, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jlblModificar)
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(volvermostrar)))
                .addGap(36, 36, 36)
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel4)
                    .addComponent(jCalendar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(8, 8, 8)
                .addComponent(jbtnMostrarMaxMinPrecipitaciones)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jLabel2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel5)
                    .addComponent(jCalendarAñoPromedioPrecipitacion, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jbtnMostrarPromMens)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jLabel3)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel6)
                    .addComponent(jCalendarAñoTemperaturaMinMax, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jbtnMostrarMaxMinTemperatura)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 172, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jbtnMostrarMaxMinPrecipitacionesActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnMostrarMaxMinPrecipitacionesActionPerformed
  DefaultListModel modelo = new DefaultListModel();
        int dia = jCalendar.getCalendar().get(Calendar.DAY_OF_MONTH), mes = jCalendar.getCalendar().get(Calendar.MONTH) + 1, año = jCalendar.getCalendar().get(Calendar.YEAR);
        double precipitacion_maxima= -20000;
        double precipitacion_minima= 20000;
        ArrayList unaLista = (ArrayList) fachada.getRegistroCRUD().Registros();
        for (int i = 0; i < unaLista.size(); i++) {
            Registro tmpRegistro = (Registro) unaLista.get(i);
            if(dia == tmpRegistro.getDia() && mes == tmpRegistro.getMes() && año == tmpRegistro.getAño()){
                if(precipitacion_minima > tmpRegistro.getPrecipitacion()) {
                    precipitacion_minima = tmpRegistro.getPrecipitacion();
                }
            }
        }
        for (int i = 0; i < unaLista.size(); i++) {
            Registro tmpRegistro = (Registro) unaLista.get(i);
            if(dia == tmpRegistro.getDia() && mes == tmpRegistro.getMes() && año == tmpRegistro.getAño()){
                if(precipitacion_minima == tmpRegistro.getPrecipitacion()) {
                    modelo.addElement("Mínimo: " + tmpRegistro.toString());
                }
            }
        }
        
        for (int i = 0; i < unaLista.size(); i++) {
            Registro tmpRegistro = (Registro) unaLista.get(i);
            if(dia == jCalendar.getCalendar().get(Calendar.DAY_OF_MONTH) && mes == jCalendar.getCalendar().get(Calendar.MONTH) + 1 && año == jCalendar.getCalendar().get(Calendar.YEAR)){
                if(precipitacion_maxima < tmpRegistro.getPrecipitacion()) {
                    precipitacion_maxima = tmpRegistro.getPrecipitacion();
                }
            }
        }
        for (int i = 0; i < unaLista.size(); i++) {
            Registro tmpRegistro = (Registro) unaLista.get(i);
            if(dia == jCalendar.getCalendar().get(Calendar.DAY_OF_MONTH) && mes == jCalendar.getCalendar().get(Calendar.MONTH) + 1 && año == jCalendar.getCalendar().get(Calendar.YEAR)){
                if(precipitacion_maxima == tmpRegistro.getPrecipitacion()) {
                    modelo.addElement("Máxima: " + tmpRegistro.toString());
                }
            }
        }
        
        this.jlstMostrar.setModel(modelo);
    }//GEN-LAST:event_jbtnMostrarMaxMinPrecipitacionesActionPerformed

    private void jbtnMostrarPromMensActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnMostrarPromMensActionPerformed
        DefaultListModel modelo = new DefaultListModel();
        double precipitacionEnero = 0, precipitacionFebrero = 0, precipitacionMarzo = 0, precipitacionAbril = 0, precipitacionMayo = 0, precipitacionJunio = 0, precipitacionJulio = 0, precipitacionAgosto = 0, precipitacionSeptiembre = 0, precipitacionOctubre = 0, precipitacionNoviembre = 0, precipitacionDiciembre = 0;
        int numero_precipitacionEnero = 0, numero_precipitacionFebrero = 0, numero_precipitacionMarzo = 0, numero_precipitacionAbril = 0, numero_precipitacionMayo = 0, numero_precipitacionJunio = 0, numero_precipitacionJulio = 0, numero_precipitacionAgosto = 0, numero_precipitacionSeptiembre = 0, numero_precipitacionOctubre = 0, numero_precipitacionNoviembre = 0, numero_precipitacionDiciembre = 0;
        double promedio_precipitacionEnero = 0, promedio_precipitacionFebrero = 0, promedio_precipitacionMarzo = 0, promedio_precipitacionAbril = 0, promedio_precipitacionMayo = 0, promedio_precipitacionJunio = 0, promedio_precipitacionJulio = 0, promedio_precipitacionAgosto = 0, promedio_precipitacionSeptiembre = 0, promedio_precipitacionOctubre = 0, promedio_precipitacionNoviembre = 0, promedio_precipitacionDiciembre = 0;
        ArrayList unaLista = (ArrayList) fachada.getRegistroCRUD().Registros();
        for (int i = 0; i < unaLista.size(); i++) {
            Registro tmpRegistro = (Registro) unaLista.get(i);
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 1){
                precipitacionEnero= precipitacionEnero + tmpRegistro.getPrecipitacion();
                numero_precipitacionEnero++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 2){
                precipitacionFebrero= precipitacionFebrero + tmpRegistro.getPrecipitacion();
                numero_precipitacionFebrero++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 3){
                precipitacionMarzo= precipitacionMarzo + tmpRegistro.getPrecipitacion();
                numero_precipitacionMarzo++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 4){
                precipitacionAbril= precipitacionAbril + tmpRegistro.getPrecipitacion();
                numero_precipitacionAbril++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 5){
                precipitacionMayo= precipitacionMayo + tmpRegistro.getPrecipitacion();
                numero_precipitacionMayo++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 6){
                precipitacionJunio= precipitacionJunio + tmpRegistro.getPrecipitacion();
                numero_precipitacionJunio++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 7){
                precipitacionJulio= precipitacionJulio + tmpRegistro.getPrecipitacion();
                numero_precipitacionJulio++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 8){
                precipitacionAgosto= precipitacionAgosto + tmpRegistro.getPrecipitacion();
                numero_precipitacionAgosto++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 9){
                precipitacionSeptiembre= precipitacionSeptiembre + tmpRegistro.getPrecipitacion();
                numero_precipitacionSeptiembre++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 10){
                precipitacionOctubre= precipitacionOctubre + tmpRegistro.getPrecipitacion();
                numero_precipitacionOctubre++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 11){
                precipitacionNoviembre= precipitacionNoviembre + tmpRegistro.getPrecipitacion();
                numero_precipitacionNoviembre++;
            }
            if(tmpRegistro.getAño() == this.jCalendarAñoPromedioPrecipitacion.getYear() && tmpRegistro.getMes() == 12){
                precipitacionDiciembre= precipitacionDiciembre + tmpRegistro.getPrecipitacion();
                numero_precipitacionDiciembre++;
            }
        }
        promedio_precipitacionEnero = precipitacionEnero / numero_precipitacionEnero;
        promedio_precipitacionFebrero = precipitacionFebrero / numero_precipitacionFebrero;
        promedio_precipitacionMarzo = precipitacionMarzo / numero_precipitacionMarzo;
        promedio_precipitacionAbril = precipitacionAbril / numero_precipitacionAbril;
        promedio_precipitacionMayo = precipitacionMayo / numero_precipitacionMayo;
        promedio_precipitacionJunio = precipitacionJunio / numero_precipitacionJunio;
        promedio_precipitacionJulio = precipitacionJulio / numero_precipitacionJulio;
        promedio_precipitacionAgosto = precipitacionAgosto / numero_precipitacionAgosto;
        promedio_precipitacionSeptiembre = precipitacionSeptiembre / numero_precipitacionSeptiembre;
        promedio_precipitacionOctubre = precipitacionOctubre / numero_precipitacionOctubre;
        promedio_precipitacionNoviembre = precipitacionNoviembre / numero_precipitacionNoviembre;
        promedio_precipitacionDiciembre = precipitacionDiciembre / numero_precipitacionDiciembre;
        modelo.addElement("El promedio de precipitaciones de Enero de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionEnero);
        modelo.addElement("El promedio de precipitaciones de Febrero de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionFebrero);
        modelo.addElement("El promedio de precipitaciones de Marzo de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionMarzo);
        modelo.addElement("El promedio de precipitaciones de Abril de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionAbril);
        modelo.addElement("El promedio de precipitaciones de Mayo de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionMayo);
        modelo.addElement("El promedio de precipitaciones de Junio de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionJunio);
        modelo.addElement("El promedio de precipitaciones de Julio de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionJulio);
        modelo.addElement("El promedio de precipitaciones de Agosto de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionAgosto);
        modelo.addElement("El promedio de precipitaciones de Septiembre de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionSeptiembre);
        modelo.addElement("El promedio de precipitaciones de Octubre de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionOctubre);
        modelo.addElement("El promedio de precipitaciones de Noviembre de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionNoviembre);
        modelo.addElement("El promedio de precipitaciones de Diciembre de " + this.jCalendarAñoPromedioPrecipitacion.getYear()+ " es: " + promedio_precipitacionDiciembre);
        this.jlstMostrar.setModel(modelo);
    }//GEN-LAST:event_jbtnMostrarPromMensActionPerformed

    private void jbtnMostrarMaxMinTemperaturaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnMostrarMaxMinTemperaturaActionPerformed
        DefaultListModel modelo = new DefaultListModel();
        double temperatura_maxima= -20000;
        double temperatura_minima= 20000;
        ArrayList unaLista = (ArrayList) fachada.getRegistroCRUD().Registros();
        for (int i = 0; i < unaLista.size(); i++) {
            Registro tmpRegistro = (Registro) unaLista.get(i);
            if(tmpRegistro.getAño() == this.jCalendarAñoTemperaturaMinMax.getYear()){
                if(temperatura_minima > tmpRegistro.getTemperatura()) {
                    temperatura_minima = tmpRegistro.getTemperatura();
                }
            }
        }
        for (int i = 0; i < unaLista.size(); i++) {
            Registro tmpRegistro = (Registro) unaLista.get(i);
            if(tmpRegistro.getAño() == this.jCalendarAñoTemperaturaMinMax.getYear()){
                if(temperatura_minima == tmpRegistro.getTemperatura()) {
                    modelo.addElement("Mínimo: " + tmpRegistro.toString());
                }
            }
        }
        
        for (int i = 0; i < unaLista.size(); i++) {
            Registro tmpRegistro = (Registro) unaLista.get(i);
            if(tmpRegistro.getAño() == this.jCalendarAñoTemperaturaMinMax.getYear()){
                if(temperatura_maxima < tmpRegistro.getTemperatura()) {
                    temperatura_maxima = tmpRegistro.getTemperatura();
                }
            }
        }
        for (int i = 0; i < unaLista.size(); i++) {
            Registro tmpRegistro = (Registro) unaLista.get(i);
            if(tmpRegistro.getAño() == this.jCalendarAñoTemperaturaMinMax.getYear()){
                if(temperatura_maxima == tmpRegistro.getTemperatura()) {
                    modelo.addElement("Máximo:" + tmpRegistro.toString());
                }
            }
        }
        this.jlstMostrar.setModel(modelo);
    }//GEN-LAST:event_jbtnMostrarMaxMinTemperaturaActionPerformed

    private void volvermostrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_volvermostrarActionPerformed

        jfrmOpciones unFrm = new jfrmOpciones();
        unFrm.setVisible(true);
        this.setVisible(false);// TODO add your handling code here:
    }//GEN-LAST:event_volvermostrarActionPerformed

    

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private com.toedter.calendar.JDateChooser jCalendar;
    private com.toedter.calendar.JYearChooser jCalendarAñoPromedioPrecipitacion;
    private com.toedter.calendar.JYearChooser jCalendarAñoTemperaturaMinMax;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JButton jbtnMostrarMaxMinPrecipitaciones;
    private javax.swing.JButton jbtnMostrarMaxMinTemperatura;
    private javax.swing.JButton jbtnMostrarPromMens;
    private javax.swing.JLabel jlblModificar;
    private javax.swing.JList<String> jlstMostrar;
    private javax.swing.JButton volvermostrar;
    // End of variables declaration//GEN-END:variables

    private String parseint(String text) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
   
   
    }
    
}
