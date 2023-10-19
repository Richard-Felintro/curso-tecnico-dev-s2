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

  let data = new Date()
  // Adiciona os dados cadastrados a um objeto
  let pessoa = {
    nome: nome,
    altura: altura,
    peso: peso,
    imc: imc,
    classificacao: classificacao,
    dataCadastro: `${data.getHours()}:${data.getMinutes()} ${data.getDate()}/${
      data.getMonth() + 1
    }/${data.getFullYear()}`,
  };

  // Adiciona o objeto a lista de objetos
  pessoas.push(pessoa);

  document.getElementById("corpo-tabela").innerHTML += `
  <tr>
      <td data-cell="nome">${pessoa.nome}</td>
      <td data-cell="altura">${pessoa.altura}</td>
      <td data-cell="peso">${pessoa.peso}</td>
      <td data-cell="valor do imc">${pessoa.imc}</td>
      <td data-cell="classificação do imc">${pessoa.classificacao}</td>
      <td data-cell="data de cadastro">${pessoa.dataCadastro}</td>
  </tr>
  `;
  //* TESTE
  pessoas.forEach(p => {
    console.log(p);
  });
}

function limparFormulario(){
  document.getElementById("nome").value = ""
  document.getElementById("altura").value = ""
  document.getElementById("peso").value = ""
}

function deletarRegistros(){
  let pessoas = []
  document.getElementById("corpo-tabela").innerHTML = ""
}

// Calculo do IMC
function calcularImc(peso, altura) {
  return (peso / altura ** 2).toFixed(1);
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
