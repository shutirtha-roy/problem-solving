package cse423.labs.lab1.task;

import com.jogamp.opengl.GL2;
import com.jogamp.opengl.GLAutoDrawable;
import com.jogamp.opengl.GLCapabilities;
import com.jogamp.opengl.GLEventListener;
import com.jogamp.opengl.GLProfile;
import com.jogamp.opengl.awt.GLCanvas;
import javax.swing.JFrame;
import java.util.concurrent.ThreadLocalRandom;

public class Lab01 implements GLEventListener{

    static GLProfile profile = GLProfile.get(GLProfile.GL2);
    static GLCapabilities capabilities = new GLCapabilities(profile);
    // The canvas 
    static GLCanvas glcanvas = new GLCanvas(capabilities);

    public static void main(String[] args) {
        //getting the capabilities object of GL2 profile
        Lab01 geometry = new Lab01();
        //creating frame
        glcanvas.addGLEventListener(geometry);
        glcanvas.setSize(600, 400);
        final JFrame frame = new JFrame ("StraightLine");
        //adding canvas to frame
        frame.getContentPane().add(glcanvas);
        frame.setSize(frame.getContentPane().getPreferredSize());
        frame.setVisible(true);
    }


    public void dispose(GLAutoDrawable arg0) {
        //method body
    }
    public void init(GLAutoDrawable drawable) {
        // method body
        //4. drive the display() in a loop
    }

    public void display(GLAutoDrawable drawable) {
        final GL2 gl = drawable.getGL().getGL2();
        gl.glBegin (GL2.GL_POINTS);
        gl.glPointSize(6.0f);
        gl.glColor3d(1, 1, 0);

        for(int i = 0; i <= 99; i++) {
            gl.glVertex2d(
                    ThreadLocalRandom.current().nextDouble(-1.0, 1.0 + 1),
                    ThreadLocalRandom.current().nextDouble(-1.0, 1.0 + 1)
            );
        }
        gl.glEnd();
    }
    public void reshape(GLAutoDrawable arg0, int arg1, int arg2, int arg3, int arg4) {
        // method body
    }
}