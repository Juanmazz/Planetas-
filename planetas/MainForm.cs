/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 4/10/2021
 * Time: 20:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace planetas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[] descripcion;
		string[] nombre;
		string[] imagenes;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
			descripcion = new string[9];
			
			descripcion[1]="Mercurio es el planeta del sistema solar más cercano al Sol y el más pequeño. Forma parte de los denominados planetas interiores y carece de satélites naturales al igual que Venus. Se conocía muy poco sobre su superficie hasta que fue enviada la sonda planetaria Mariner 10 y se hicieron observaciones con radar y radiotelescopios. Posteriormente fue estudiado por la sonda MESSENGER de la NASA y actualmente la astronave de la Agencia Europea del Espacio (ESA) denominada BepiColombo, lanzada en octubre de 2018, se halla en vuelo rumbo a Mercurio a donde llegará en 2025 y se espera que aporte nuevos conocimientos sobre el origen y composición del planeta, así como de su geología y campo magnético";
			descripcion[2]="Venus es el segundo planeta del sistema solar en orden de proximidad al Sol y el tercero en cuanto a tamaño en orden ascendente después de Mercurio y Marte.";
			descripcion[3]="La Tierra (del latín Terra,​ deidad romana equivalente a Gea, diosa griega de la feminidad y la fecundidad) es un planeta del sistema solar que gira alrededor de su estrella —el Sol— en la tercera órbita más interna. Es el más denso y el quinto mayor de los ocho planetas del sistema solar. También es el mayor de los cuatro terrestres o rocosos";
			descripcion[4]="Marte es el cuarto planeta en orden de distancia al Sol y el segundo más pequeño del sistema solar, después de Mercurio. Recibió su nombre en homenaje al dios de la guerra de la mitología romana (Ares en la mitología griega), y también es conocido como «el planeta rojo";
			descripcion[5]="Júpiter es el planeta más grande del sistema solar y el quinto en orden de lejanía al Sol. Es un gigante gaseoso que forma parte de los denominados planetas exteriores.";
			descripcion[6]="Saturno es el sexto planeta del sistema solar contando desde el Sol, el segundo en tamaño y masa después de Júpiter y el único con un sistema de anillos visible desde la Tierra";
			descripcion[7]="Urano es el séptimo planeta del sistema solar, el tercero de mayor tamaño, y el cuarto más masivo. Se llama así en honor de la divinidad griega del cielo Urano (del griego antiguo Οὐρανός), el padre de Crono (Saturno) y el abuelo de Zeus (Júpiter).";
			descripcion[8]="Neptuno es el octavo planeta en distancia respecto al Sol y el más lejano del sistema solar. Forma parte de los denominados planetas exteriores, y dentro de estos, es uno de los gigantes helados, y es el primero que fue descubierto gracias a predicciones matemáticas.";
			
				
			nombre = new string[9];
			nombre[1]="Mercurio";
			nombre[2]="Venus";
			nombre[3]="Tierra";
			nombre[4]="Marte";
			nombre[5]="Jupiter";
			nombre[6]="Saturno";
			nombre[7]="Urano";
			nombre[8]="Neptuno";
			
			imagenes = new string[9];
			imagenes[1]="C:\\Users\\LAB03\\Desktop\\planmetas\\mercurio";
			imagenes[2]="C:\\Users\\LAB03\\Desktop\\planmetas\\venus";
			imagenes[3]="C:\\Users\\LAB03\\Desktop\\planmetas\\tierra";
			imagenes[4]="C:\\Users\\LAB03\\Desktop\\planmetas\\marte";
			imagenes[5]="C:\\Users\\LAB03\\Desktop\\planmetas\\jupiter";
			imagenes[6]="C:\\Users\\LAB03\\Desktop\\planmetas\\saturno";
			imagenes[7]="C:\\Users\\LAB03\\Desktop\\planmetas\\urano";
			imagenes[8]="C:\\Users\\LAB03\\Desktop\\planmetas\\neptuno(3)";
	
		}
		void Pic1Click(object sender, EventArgs e)
		{
	
			PictureBox aux = (PictureBox)sender;
			piccenter.Image= aux.Image;
			
		
			lblcenter.Text = nombre[int.Parse(aux.Tag.ToString())];
			
			lblcenter2.Text = descripcion[int.Parse(aux.Tag.ToString())];
				
		}
		
	}
}
