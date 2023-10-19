console.clear()

const numeros = [1, 2, 5, 10, 300];

const soma = numeros.reduce((valorInicial, n) => {
    return valorInicial + n
}, 20)

console.log(soma);