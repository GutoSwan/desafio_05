using desafio5;



Aluno orlandoAluno = new Aluno("orlando", 12, 5);

Aluno scobyAluno = new Aluno("scoby", 15, 4);

Aluno chubsAluno = new Aluno("chubs", 23, 8);

List<Aluno> alunos = new List<Aluno>();
alunos.Add(orlandoAluno);
alunos.Add(scobyAluno);
alunos.Add(chubsAluno);


StreamWriter sw = new StreamWriter("D:\\desafi C#\\desafio5\\alunosalunosNota.csv");
sw.WriteLine("nome" + ";" + "idade" + ";" + "nota");
foreach (var aluninho in alunos)
{
    sw.WriteLine(aluninho.nome + ";" + aluninho.idade + ";" + aluninho.nota);
}
sw.WriteLine("soma das notas: "+ ";" + alunos.Select(x => x.nota).Sum());
sw.Close();