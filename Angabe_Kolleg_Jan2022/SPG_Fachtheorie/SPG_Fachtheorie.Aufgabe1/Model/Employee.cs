namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
