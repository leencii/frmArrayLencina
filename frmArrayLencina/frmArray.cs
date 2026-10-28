namespace frmArrayLencina
{
    public partial class frmArray : Form
    {
        //declarar string
        string[] vectorGrupoA = new string[4];
        string[] vectorGrupoB = new string[3];
        string[] vectorGrupoC = new string[3];
        public frmArray()
        {
            InitializeComponent();

        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            cboGrupo.Items.Add("Grupo A");
            cboGrupo.Items.Add("Grupo B");
            cboGrupo.Items.Add("Grupo C");

            //grbar en algun lugar del array
            vectorGrupoA[0] = "CPU";
            vectorGrupoA[1] = "MICRO";
            vectorGrupoA[2] = "PLACA";
            vectorGrupoA[3] = "MEMORIA";

            vectorGrupoB[0] = "VISUAL";
            vectorGrupoB[1] = "C";
            vectorGrupoB[2] = "DESKTOP";

            vectorGrupoC[0] = "SERVER";
            vectorGrupoC[1] = "AWS";
            vectorGrupoC[2] = "CLOUD";


        }




        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboGrupo.Text)
            {

                case "Grupo A":
                    ltsLista.Items.Clear();
                    ltsLista.Items.Add("CPU");
                    ltsLista.Items.Add("MICRO");
                    ltsLista.Items.Add("PLACA");
                    ltsLista.Items.Add("MEMORIA");
                    ltsLista.Items.Clear();

                    for (int indice = 0; indice < vectorGrupoA.Length; indice++)
                    {

                        ltsLista.Items.Add(vectorGrupoA[indice]);
                    }
                    break;

                //recorrer vector de inicio a fin


                case "Grupo B":
                    ltsLista.Items.Clear();
                    ltsLista.Items.Add("VISUAL");
                    ltsLista.Items.Add("C#");
                    ltsLista.Items.Add("DESKTOP");
                    ltsLista.Items.Clear();


                    for (int indice = 0; indice < vectorGrupoB.Length; indice++)
                    {
                        ltsLista.Items.Add(vectorGrupoB[indice]);
                    }
                    break;



                case "Grupo C":
                    ltsLista.Items.Clear();
                    ltsLista.Items.Add("SERVER");
                    ltsLista.Items.Add("AWS");
                    ltsLista.Items.Add("CLOUD");
                    ltsLista.Items.Clear();

                    for (int indice = 0; indice < vectorGrupoC.Length; indice++)
                    {
                        ltsLista.Items.Add(vectorGrupoC[indice]);
                    }
                    break;




            }
        }
        //declarar global

        int IndiceGrabar = 0;

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (cboGrupos2.Text)
            {
                case "Grupo A":
                    vectorGrupoA[IndiceGrabar] = txtDato.Text;
                    IndiceGrabar++;
                    lblMensaje.Text = "Almacenado..." + txtDato.Text;
                    txtDato.Text = "";
                    break;

                default:
                    break;
            }
        }
    }
}

   

