console.clear();
// const somar = (x,y) => {
//     return x + y
// }

// const dobro = (x) => {
//     return 2 * x
// }

// const double = x => 2 * x

// console.log(somar(50,10));
// console.log(dobro(10));
// console.log(double(10));

// const boaTarde = () => console.log("Boa tarde :)")
// boaTarde()

const convidados = [
  {nome: "Carlos",   idade: 36},
  {nome: "João",     idade: 43},
  {nome: "Pedrinho", idade: 03},
  {nome: "Joaquin",  idade: 28},
  {nome: "Claiton",  idade: 43}
];
convidados.forEach((con) => {
  console.log(`Convidado ${con.nome} : idade ${con.idade}`);
});
