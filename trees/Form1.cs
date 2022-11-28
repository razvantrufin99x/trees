namespace trees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public _tree treeOne = new _tree();
        public void faddtree() 
        {
                treeOne.root.id = 0;
                treeOne.root.value = "start";
                treeOne.addLeft(1,"d",new _node());
                treeOne.addRight(2,"a",new _node());
        }
       
        public void freadtree(ref _tree tr, ref TextBox t)
        {
            string newline = Environment.NewLine;
            t.Text = "Tree" + tr.GetType().Name;
            t.Text += newline;
            t.Text += tr.root.id.ToString();
            t.Text += '\t';
            t.Text += tr.root.value.ToString();
            t.Text += newline;
            t.Text += tr.root._nodeLeft.id.ToString();
            t.Text += '\t';
            t.Text += tr.root._nodeLeft.value.ToString();
            t.Text += newline;
            t.Text += tr.root._nodeRight.id.ToString();
            t.Text += '\t';
            t.Text += tr.root._nodeRight.value.ToString();
            t.Text += newline;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            faddtree();
            freadtree(ref treeOne, ref textBox1);
        }

        //after press a button add a new _node for wach letter to 3 _nodes posibble
        ////in dictionari letter folow the letters before
        //search for a posible word or a match in dictionary
    }
}