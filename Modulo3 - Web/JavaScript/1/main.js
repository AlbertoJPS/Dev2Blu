function clickBotaoExemplo01() {
    alert("Clicou!")
}

function apresentaNome() {
    alert("Alberto Santos")
}

function uso_IF() {
    let idade = prompt("Digite sua idade: ")

    let numero = Number(idade);

    if (idade <= 17) {
        alert("Você é menor de idade!")
    } 
    else if (idade <= 50) {
        alert("Adulto pouco experiênte!")
    } 
    else {
        alert("Adulto experiente!")
    }
}

function uso_FOR() {
    let nomes = ["Alberto", "Bruna", "Carlos", "Daniela", "Eduardo"];

    for (let i = 0; i < nomes.length; i++) {
        console.log(nomes[i]);
    }
}
function uso_SWITCH() {
    let diaSemana = prompt("Digite um número de 1 a 7: ")
    let numero = Number(diaSemana);
    let dia = ""
    switch (numero) {
        case 1:
            dia = "Domingo"
            break;
        case 2:
            dia = "Segunda-feira"
            break;
        case 3:
            dia = "Terça-feira"
            break;
        case 4:
            dia = "Quarta-feira"
            break;
        case 5:
            dia = "Quinta-feira"
            break;
        case 6:
            dia = "Sexta-feira"
            break;
        case 7:
            dia = "Sábado"
            break;
        default:
            dia = "Número inválido!"
            break;
    }
    alert(dia); 
}
function uso_WHILE() {
    let infos = [];
    let stop = false;

    while (!stop) {
        let info = prompt("Infome algo para eu logar!");
        stop = info === "Parar";

        infos.push(info);
    }
}
function uso_DOWHILE() {
    let contador = 0;
    do {
        console.log("Contador: " + contador);
        contador++;
    } while (contador < 5);
    alert("Veja o console do navegador!")
}

function uso_FOREACH() {
    let nomes = ["Alberto", "Bruna", "Carlos", "Daniela", "Eduardo"];
    for (let nome of nomes) {
        console.log(nome);
    }
}   

