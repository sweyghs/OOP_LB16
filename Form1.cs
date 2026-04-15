namespace LB_5_oop
{
    public partial class Form1 : Form
    {
        private Polynomial poly1;
        private Polynomial poly2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ParsePolynomials();
                Polynomial result = poly1 + poly2;
                lblResult.Text = $"Результат додавання:\n{poly1} + {poly2} = {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

    private void ParsePolynomials()
        {
            if (string.IsNullOrWhiteSpace(txtPoly1.Text))
                throw new Exception("Введіть коефіцієнти многочлена P(x)");
            if (string.IsNullOrWhiteSpace(txtPoly2.Text))
                throw new Exception("Введіть коефіцієнти многочлена Q(x)");

            poly1 = Polynomial.Parse(txtPoly1.Text);
            poly2 = Polynomial.Parse(txtPoly2.Text);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                ParsePolynomials();
                Polynomial result = poly1 - poly2;
                lblResult.Text = $"Результат віднімання:\n{poly1} - {poly2} = {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                ParsePolynomials();
                Polynomial result = poly1 * poly2;
                lblResult.Text = $"Результат множення:\n({poly1}) * ({poly2}) = {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                if (poly1 == null && !string.IsNullOrWhiteSpace(txtPoly1.Text))
                    poly1 = Polynomial.Parse(txtPoly1.Text);

                if (poly1 == null)
                {
                    MessageBox.Show("Спочатку введіть многочлен P(x)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double x = double.Parse(txtX.Text);
                double value = poly1.Evaluate(x);
                lblValue.Text = $"P({x}) = {value}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
