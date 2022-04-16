package cse423.labs.lab3.task;

import javax.swing.*;
import com.jogamp.opengl.*;
import com.jogamp.opengl.awt.GLCanvas;
import com.jogamp.opengl.glu.GLU;
import java.lang.Math;


/**
 * Created by asif on 5/10/2021.
 */

public class Lab03 implements GLEventListener{

    private GLU glu;

    public void init(GLAutoDrawable gld) {
        GL2 gl = gld.getGL().getGL2();
        glu = new GLU();
        gl.glClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        gl.glViewport(-100, -50, 50, 100);
        gl.glMatrixMode(GL2.GL_PROJECTION);
        gl.glLoadIdentity();
        glu.gluOrtho2D(-100.0, 100.0, -100.0, 100.0);
    }

    public void display(GLAutoDrawable drawable) {
        final GL2 g1 = drawable.getGL().getGL2();



        midPointLine(g1, -17f, 20f, -5f, 20f);
        midPointLine(g1, -5f, -10f, -4.9f, 19f);
        midPointLine(g1, -17f, 5f, -5f, 5f);
        midPointLine(g1, -17f, -10f, -5f, -10f);

        midPointLine(g1, 10f, 20f, 28f, 20f);
        midPointLine(g1, 10f, -10f, 28f, -10f);
        midPointLine(g1, 10f, 20f, 10f, -10f);
        midPointLine(g1, 28f, 20f, 28f, -10f);

    }

    public void reshape(GLAutoDrawable arg0, int arg1, int arg2, int arg3, int arg4) {
        // method body
    }


    public void dispose(GLAutoDrawable arg0) {
        //method body
    }

    public void midPointLine(GL2 gl, double x1, double y1, double x2, double y2) {

        gl.glColor3d(0, 1, 0);
        gl.glPointSize(4.0f);

        gl.glBegin (GL2.GL_POINTS);


        double d, x, y, dx, dy, E, NE;

        int zone = findZone(x1, y1, x2, y2);
        double[] zone0pts = convertToZone0(x1, y1, zone);
        x1 = zone0pts[0];
        y1 = zone0pts[1];
        zone0pts = convertToZone0(x2, y2, zone);
        x2 = zone0pts[0];
        y2 = zone0pts[1];
        dx = x2 - x1;
        dy = y2 - y1;
        d = 2 * dy - dx;
        E = 2 * dy;
        NE = 2 * (dy - dx);

        for (x = x1, y = y1; x < x2; ) {
            if( d <= 0){
                d = d + E;
            }
            else {
                d = d + NE;
                y = y + 0.001;
            }
            x = x + 0.001;
            
            double[] originalZonePoints = convertToOriginalZone(x, y, zone);
            gl.glVertex2d(originalZonePoints[0], originalZonePoints[1]);
        }
        gl.glEnd();

    }


    public int findZone(double x1, double y1, double x2, double y2){
        int zone = -999;
        double dx = x2 - x1, dy = y2 - y1;
        double modulusDx = Math.abs(dx), modulusDy = Math.abs(dy);

        if (modulusDx > modulusDy){
            if (dx > 0 && dy > 0){
                zone = 0;
            }
            else if(dx < 0 && dy > 0){
                zone = 3;
            }
            else if(dx < 0 && dy < 0){
                zone = 4;
            }
            else {
                zone = 7;
            }
        }
        else {
            if (dx > 0 && dy > 0){
                zone = 1;
            }
            else if(dx < 0 && dy > 0){
                zone = 2;
            }
            else if(dx < 0 && dy < 0){
                zone = 5;
            }
            else{
                zone = 6;
            }
        }
        return zone;
    }

    public double[] convertToZone0(double x, double y, int zone){
        double[] output = new double[2];
        switch (zone){
            case 0:
                output[0] = x;
                output[1] = y;
                break;
            case 1:
                output[0] = y;
                output[1] = x;
                break;
            case 2:
                output[0] = y;
                output[1] = -x;
                break;
            case 3:
                output[0] = -x;
                output[1] = y;
                break;
            case 4:
                output[0] = -x;
                output[1] = -y;
                break;
            case 5:
                output[0] = -y;
                output[1] = -x;
                break;
            case 6:
                output[0] = -y;
                output[1] = x;
                break;
            case 7:
                output[0] = x;
                output[1] = -y;
                break;
        }
        return output;
    }

    public double[] convertToOriginalZone(double x, double y, int zone){
        double[] output = new double[2];

        switch (zone) {
            case 0:
                output[0] = x;
                output[1] = y;
                break;
            case 1:
                output[0] = y;
                output[1] = x;
                break;
            case 2:
                output[0] = -y;
                output[1] = x;
                break;
            case 3:
                output[0] = -x;
                output[1] = y;
                break;
            case 4:
                output[0] = -x;
                output[1] = -y;
                break;
            case 5:
                output[0] = -y;
                output[1] = -x;
                break;
            case 6:
                output[0] = y;
                output[1] = -x;
                break;
            case 7:
                output[0] = x;
                output[1] = -y;
                break;
        }
        return output;
    }

    public static void main(String[] args) {
        //getting the capabilities object of GL2 profile
        final GLProfile profile = GLProfile.get(GLProfile.GL2);
        GLCapabilities capabilities = new GLCapabilities(profile);
        // The canvas
        final GLCanvas glcanvas = new GLCanvas(capabilities);
        glcanvas.addGLEventListener(new Lab03());
        glcanvas.setSize(500, 550);
        //creating frame
        final JFrame frame = new JFrame ("Midpoint Line");
        //adding canvas to frame
        frame.getContentPane().add(glcanvas);
        frame.setSize(frame.getContentPane().getPreferredSize());
        frame.setVisible(true);
    }
}