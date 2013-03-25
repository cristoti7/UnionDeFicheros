using System;
using System.IO;
namespace MezclaDeArchivos
{
	class Principal
	{

		public Principal(){

		}

		public void EmpezarPrograma()
		{ 
			StreamReader LeyendoArchivo1;
			StreamReader LeyendoArchivo2;
			StreamWriter CreandoArchivoFinal;
			StreamReader LeyendoArchivoFinal;
			
			string nombreFichero1;
			string nombreFichero2;
			string nombreFicheroFinal;
			string lineasFichero1;
			string lineasFichero2;
			string linea;
			Console.WriteLine("Introduzca el nombre del fichero 1"); 
			nombreFichero1 = Console.ReadLine();
			Console.WriteLine("Introduzca el nombre del fichero 2"); 
			nombreFichero2 = Console.ReadLine(); 
			try 
			{ 
				LeyendoArchivo1 = File.OpenText(nombreFichero1); 
				LeyendoArchivo2 = File.OpenText(nombreFichero2); 
				
				Console.WriteLine("Introduzca el nombre del fichero Final"); 
				nombreFicheroFinal=Console.ReadLine();
				CreandoArchivoFinal=File.CreateText(nombreFicheroFinal);
				do 
				{ 
					lineasFichero1 = LeyendoArchivo1.ReadLine(); 
					lineasFichero2 =LeyendoArchivo2.ReadLine();
					if (lineasFichero1 != null) {
						CreandoArchivoFinal.WriteLine(lineasFichero1); 
					}
					if(lineasFichero2 != null){
						CreandoArchivoFinal.WriteLine(lineasFichero2); 
					}
				} 
				while (lineasFichero1 != null && lineasFichero2 != null );
				
				
				
				LeyendoArchivo1.Close();
				LeyendoArchivo2.Close();
				CreandoArchivoFinal.Close ();
				
			} 
			catch (Exception exp) 
			{ 
				Console.WriteLine("El archivo no existe : {0}", exp.Message);
				return; 
			} 
			LeyendoArchivoFinal= File.OpenText(nombreFicheroFinal);
			try 
			{ 
				do 
				{ 
					linea =  LeyendoArchivoFinal.ReadLine(); 
					if (linea != null) 
						Console.WriteLine( linea ); 
				} 
				
				while (linea != null);
				LeyendoArchivoFinal.Close();
			}
			catch ( Exception errorDeFormarto)
			{ 
				Console.WriteLine("error intenta con :.txt  {0} ",errorDeFormarto.Message);
			}
			
		}




		

		public static void Main() 
		{

			Principal miPrograma = new Principal();
			miPrograma.EmpezarPrograma();

		}
	}
}
