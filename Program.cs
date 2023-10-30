Console.Clear();
Console.WriteLine("----- Horas Extras dos funcionarios do Supermercado -----\n");
Console.WriteLine("Salario + horas extras Açougueiros:");
Console.WriteLine("-----");

Console.WriteLine($"Salario-hora Jefferson = {10.77:C}, {220} horas mensais, fez {3} horas-extras. Salário total do funcionario = {Salario(10.77, 220, 3):C}");
Console.WriteLine($"Salario-hora José = {10.77:C}, {220} horas mensais, fez {5} horas-extras. Salário total do funcionario = {Salario(10.77, 220, 5):C}");
Console.WriteLine();


Console.WriteLine("Salario + horas extras Operadores de loja:");
Console.WriteLine("-----");

Console.WriteLine($"Salario-hora Lucas = {7.04:C}, {220} horas mensais, fez {2} horas-extras. Salário total do funcionario = {Salario(7.04, 220, 2):C}");
Console.WriteLine($"Salario-hora Carlos = {7.04:C}, {220} horas mensais, fez {7} horas-extras. Salário total do funcionario = {Salario(7.04, 220, 7):C}");
Console.WriteLine();


Console.WriteLine("Salario + horas extras Repositores dos Pereciveis:");
Console.WriteLine("-----");

Console.WriteLine($"Salario-hora João = {8.5:C}, {220} horas mensais, fez {2} horas-extras. Salário total do funcionario = {Salario(8.5, 220, 2):C}");
Console.WriteLine($"Salario-hora Fernanda = {8.5:C}, {220} horas mensais, fez {4} horas-extras. Salário total do funcionario = {Salario(8.5, 220, 4):C}");
Console.WriteLine();

double Salario(double salarioHora, double horasTotais, double horasExtras)
{
    return (salarioHora * (horasTotais - horasExtras)) + (salarioHora * horasExtras * 1.4);
}



