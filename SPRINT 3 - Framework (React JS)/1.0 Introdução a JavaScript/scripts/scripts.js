function calcular() {
  event.preventDefault();
  let res;
  let n1 = parseFloat(document.getElementById("numero1").value);
  let n2 = parseFloat(document.getElementById("numero2").value);
  let op = document.getElementById("operacao").value;

  if (isNaN(n1) || isNaN(n2)) {
    res = "Operação inválida";
  } else if (op == "+") {
    res = somar(n1, n2);
  } else if (op == "-") {
    res = subtrair(n1, n2);
  } else if (op == "*") {
    res = multiplicar(n1, n2);
  } else if (op == "/") {
    res = dividir(n1, n2);
  } else {
    res = "Operação inválida";
  }
  document.getElementById("resultado").innerHTML = res;
}

function somar(x, y) {
  return x + y;
}
function subtrair(x, y) {
  return x - y;
}
function multiplicar(x, y) {
  return x * y;
}
function dividir(x, y) {
  if (y == 0) {
    return "Divisão inválida";
  }
  return x / y;
}
