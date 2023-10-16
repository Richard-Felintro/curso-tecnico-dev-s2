let richard = {
    nome   : "Richard",
    idade  : 17,
    altura : 1.75
}

richard.peso = 75

let carlos = new Object()
carlos.nome = "Carlos"
carlos.idade = 36
carlos.sobrenome = "Roque"

// console.log(richard, carlos)

let pessoas = []
pessoas.push(richard, carlos)

// console.log(pessoas)

pessoas.forEach(function(p,i){
    console.log(`Nome ${i+1}: ${p.nome}`)
})