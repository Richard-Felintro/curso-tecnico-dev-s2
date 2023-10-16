let pessoas = [];
function calcular(e) {
  e.preventDefault();

  // Obtém os valores enviados pelo usuário
  let nome = document.getElementById("nome").value;
  let altura = parseFloat(document.getElementById("altura").value);
  let peso = parseFloat(document.getElementById("peso").value);

  // Verifica se os valores impostos pelo usuário são válidos para o calculo e registro
  if (isNaN(altura) || isNaN(peso) || nome == "") {
    alert("Campos preenchidos incorretamente");
    return;
  }

  // Calculo do IMC
  let imc = calcularImc(peso, altura);

  // Determina a classificação de seu IMC
  let classificacao = gerarClassificacao(imc);

  // Adiciona os dados cadastrados a um objeto
  let pessoa = {
    nome: nome,
    altura: altura,
    peso: peso,
    imc: imc,
    classificacao: classificacao,
  };

  // Adiciona o objeto a lista de objetos
  pessoas.push(pessoa);

  //* TESTE
  console.log(pessoas);
}

// Calculo do IMC
function calcularImc(peso, altura) {
  return (peso / (altura ** 2)).toFixed(1);
}

// Determina a classificação de seu IMC
function gerarClassificacao(imc) {
  if (imc < 18.5) {
    return "Magreza Severa";
  } else if (imc < 25) {
    return "Eutrofia";
  } else if (imc < 30) {
    return "Sobrepeso";
  } else if (imc < 35) {
    return "Obesidade Grau I";
  } else if (imc < 40) {
    return "Obesidade Grau II";
  } else {
    return "Obesidade Grau III";
  }
}
