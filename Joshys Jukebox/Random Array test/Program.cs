int numLimit = "10";
int numAmount = "42";
int drawHolder = "0";
static void int DrawNumbers(numLimit, numAmount);
{
    drawHolder = Enumerable.Range(0, numLimit).OrderBy(x => new Guid()).Take(numAmount);
}