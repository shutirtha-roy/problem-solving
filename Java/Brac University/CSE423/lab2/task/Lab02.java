import com.jogamp.opengl.GL2;
import com.jogamp.opengl.GLAutoDrawable;
import com.jogamp.opengl.GLCapabilities;
import com.jogamp.opengl.GLEventListener;
import com.jogamp.opengl.GLProfile;
import com.jogamp.opengl.awt.GLCanvas;
import com.jogamp.opengl.glu.GLU;
import javax.swing.JFrame;

public class Lab02 implements GLEventListener{

    private GLU glu;

    public void display(GLAutoDrawable drawable) {
        final GL2 gl = drawable.getGL().getGL2();
        //3
        DDA(gl, -2,-4,-2,40);
        DDA(gl, -15,-4,-2,-4);
        DDA(gl, -15,40,-2,40);
        DDA(gl, -15,17,-2,17);

        //0
        DDA(gl, 5,-4,5,40);
        DDA(gl, 20,-4,20,40);
        DDA(gl, 4,-4,20,-4);
        DDA(gl, 5,40,20,40);
    }

    public void dispose(GLAutoDrawable arg0) {
        //method body
    }


    public void init(GLAutoDrawable gld) {
        GL2 gl = gld.getGL().getGL2();
        glu = new GLU();
        gl.glViewport(-200, -100, 100, 200);
        gl.glMatrixMode(GL2.GL_PROJECTION);
        gl.glLoadIdentity();
        glu.gluOrtho2D(-100.0, 100.0, -100.0, 100.0);
    }

    public void reshape(GLAutoDrawable arg0, int arg1, int arg2, int arg3, int arg4) {
        // method body
    }

    public void DDA(GL2 gl, float x1, float y1, float x2, float y2) {

        gl.glPointSize(4.0f);
        gl.glColor3d(1, 1, 0);

        float m = (y2-y1)/(x2-x1);

        float x=x1;
        float y=y1;
        gl.glBegin(GL2.GL_POINTS);

        if(-1< m && m < 1 ) {
            while(x<x2) {
                x += 1;
                y += m;
                gl.glVertex2d(x,y);
            }
        }
        else {
            while(y<y2) {
                y +=1;
                x +=(1/m);
                gl.glVertex2d(x,y);
            }
        }
        gl.glEnd();
    }


    public static void main(String[] args) {
        final GLProfile geometry = GLProfile.get(GLProfile.GL2);
        GLCapabilities capabilities = new GLCapabilities(geometry);
        final GLCanvas glcanvas = new GLCanvas(capabilities);
        Lab02 lineID = new Lab02();
        glcanvas.addGLEventListener(lineID);
        glcanvas.setSize(500, 500);
        final JFrame frame = new JFrame ("ID");
        frame.getContentPane().add(glcanvas);
        frame.setSize(frame.getContentPane().getPreferredSize());
        frame.setVisible(true);
    }
}