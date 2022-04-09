using desafio5;



Aluno orlandoAluno = new Aluno("orlando", 12, 5);

Aluno scobyAluno = new Aluno("scoby", 15, 4);

Aluno chubsAluno = new Aluno("chubs", 23, 8);

List<Aluno> alunos = new List<Aluno>();
alunos.Add(orlandoAluno);
alunos.Add(scobyAluno);
alunos.Add(chubsAluno);


foreach (var aluninho in alunos)
{
    StreamWriter sw = new StreamWriter("D:\\desafi C#\\desafio5\\"+ aluninho.nome + ".csv");
    sw.WriteLine(aluninho.nome + ";" + aluninho.idade + ";" + aluninho.nota);
    sw.Close();
}
//sw.WriteLine("soma das notas: " + ";" + alunos.Select(x => x.nota).Sum());
