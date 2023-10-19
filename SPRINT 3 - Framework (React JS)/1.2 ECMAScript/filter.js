// FILTER - retorna um novo array apenas com os elementos que atendem a condição

// const numeros = [1, 2, 5, 10, 300];

// const maiorQue10 = numeros.filter((x) => {
//     return x > 10
// });

// console.log(numeros);
// console.log(maiorQue10);

const comentarios = [
  { comentario: "bla bla bla", exibe: true },
  { comentario: "bla blu blo", exibe: true },
  { comentario: "EVENTO DE MERDA", exibe: false },
];

const filtrado = comentarios.filter((c) => {
  return c.exibe === true;
});

filtrado.forEach((c) => {
  console.log(c.comentario);
});
