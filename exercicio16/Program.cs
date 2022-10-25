tp_no Remove(ref tp_no l)
{
    tp_no no = null;
    if (l != null)
    {
        no = l;
        l = l.prox;
        no.prox = null;
    }
    return no;
}
void Insere(ref tp_no l, int v)
{
    tp_no no = new tp_no();
    no.valor = v;
    if (l != null)
        no.prox = l;
    l = no;
}

tp_no lista = null;
tp_no elem;
Insere(ref lista,20);
Insere(ref lista,30);
Insere(ref lista,40);
elem = Remove(ref lista);
Console.WriteLine(elem.valor);
elem = Remove(ref lista);
Console.WriteLine(elem.valor);
class tp_no
{
    public int valor;
    public tp_no prox;
}
