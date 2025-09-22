// --- CÓDIGO DO MODAL (VERSÃO FINAL COM 'ENTER' GLOBAL) ---
const modalOverlay = document.getElementById('modal-overlay');
const customAlert = document.getElementById('custom-alert');
const alertTitle = document.getElementById('alert-title');
const alertBody = document.getElementById('alert-body');
const alertOkBtn = document.getElementById('alert-ok-btn');
const inputContainer = document.getElementById('input-container');
const alertInput = document.getElementById('alert-input');

// Esta função irá lidar com o pressionamento de teclas quando o modal estiver aberto
const handleGlobalKeyPress = (event) => {
    // Verifica se a tecla pressionada foi a 'Enter'
    if (event.key === 'Enter') {
        // Impede qualquer comportamento padrão do navegador (como submeter um formulário)
        event.preventDefault();
        // Simula um clique no nosso botão OK
        alertOkBtn.click();
    }
};


/**
 * Função principal para controlar e mostrar o modal.
 * @param {object} options - Um objeto com as configurações do modal.
 * @param {string} options.title - O título.
 * @param {string} options.body - O texto principal.
 * @param {boolean} [options.showInput=false] - Se deve ou não mostrar o campo de input.
 * @param {function} [options.callback] - Função a ser executada ao clicar em OK.
 */
function showCustomAlert(options) {
    // Configurações padrão
    const { title, body, showInput = false, callback } = options;

    // Atualiza o conteúdo
    alertTitle.textContent = title;
    alertBody.textContent = body;

    // Mostra ou esconde o campo de input
    if (showInput) {
        inputContainer.style.display = 'block';
        alertInput.value = '';
        // Foca no input para que o usuário possa digitar imediatamente
        setTimeout(() => alertInput.focus(), 100);
    } else {
        inputContainer.style.display = 'none';
    }
    
    // Mostra o modal na tela
    modalOverlay.classList.remove('hidden');
    customAlert.classList.remove('hidden');

    // ADICIONA o "ouvinte" de teclas ao documento
    document.addEventListener('keydown', handleGlobalKeyPress);

    // Define a ação do botão OK
    alertOkBtn.onclick = () => {
        const inputValue = showInput ? alertInput.value : null;

        // Esconde o modal
        modalOverlay.classList.add('hidden');
        customAlert.classList.add('hidden');
        
        // REMOVE o "ouvinte" de teclas para não interferir com o resto da página
        document.removeEventListener('keydown', handleGlobalKeyPress);

        // Se existir uma função de callback, a executa, passando o valor do input
        if (typeof callback === 'function') {
            callback(inputValue);
        }
    };
} 

//Lista de Exercícios 1 ------------------------------------------------


// Operadores Aritméticos

function aritmeticos01() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e exiba a soma deles.");
    let num1 = parseFloat(prompt("Digite o primeiro número:"));
    let num2 = parseFloat(prompt("Digite o segundo número:"));
    let soma = num1 + num2;
    alert(`A soma entre ${num1} e ${num2} é igual a ${soma}`);
}

function aritmeticos02() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e mostre a diferença entre o primeiro e o segundo número.");
    let num1 = parseFloat(prompt("Digite o primeiro número:"));
    let num2 = parseFloat(prompt("Digite o segundo número:"));
    let diferenca = num1 - num2;
    alert(`A diferença entre ${num1} e ${num2} é igual a ${diferenca}`);
}
function aritmeticos03() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e exiba o produto deles.");
    let num1 = parseFloat(prompt("Digite o primeiro número:"));
    let num2 = parseFloat(prompt("Digite o segundo número:"));
    let produto = num1 * num2;
    alert(`O produto entre ${num1} e ${num2} é igual a ${produto}`);
}
function aritmeticos04() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e mostre o resultado da divisão do primeiro pelo segundo. (Considere a divisão inteira, sem ponto flutuante.).");
    let num1 = parseInt(prompt("Digite o primeiro número:"));
    let num2 = parseInt(prompt("Digite o segundo número:"));
    let quociente = Math.floor(num1 / num2);
    alert(`O quociente entre ${num1} e ${num2} é igual a ${quociente}`);
}
function aritmeticos05() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e exiba o resto da divisão do primeiro pelo segundo.");
    let num1 = parseInt(prompt("Digite o primeiro número:"));
    let num2 = parseInt(prompt("Digite o segundo número:"));
    let resto = num1 % num2;
    alert(`O resto da divisão entre ${num1} e ${num2} é igual a ${resto}`);
}



// Operadores de Atribuição

function atribuicao01() {
    alert("Exercício: Escreva um programa que declare uma variável inteira, atribua a ela um valor digitado pelo usuário e exiba esse valor.");
    let num;
    num = parseInt(prompt(`Digite um número inteiro:`));
    alert(`O valor inteiro digitado é: ${num}`);
}
function atribuicao02() {
    alert("Exercício: Escreva um programa que declare uma variável inteira, atribua um valor a ela, depois adicione um valor digitado pelo usuário a essa variável e exiba o resultado.");
    let num = 10;
    entrada = parseInt(prompt(`Temos ${num}. Quanto você quer somar a ele?`));
    num += entrada;
    alert(`Com o valor que você escolheu, teremos: ${num}`);
}
function atribuicao03() {
    alert("Exercício: Escreva um programa que declare uma variável inteira, atribua um valor inicial, depois subtraia um valor digitado pelo usuário dessa variável e mostre o resultado.");
    let num = 20;
    entrada = parseInt(prompt(`Temos ${num}. Quanto você quer subtrair dele?`));
    num -= entrada;
    alert(`Com o valor que você escolheu, teremos: ${num}`);
}
function atribuicao04() {
    alert("Exercício: Escreva um programa que declare uma variável inteira, atribua um valor a ela, multiplique essa variável por um número digitado pelo usuário e exiba o resultado.");
    let num = 20;
    entrada = parseInt(prompt(`Temos ${num}. Por qual número você quer multiplicá-lo?`));
    num *= entrada;
    alert(`Com o valor que você escolheu, teremos: ${num}`);
}
// function atribuicao05() {
//     alert("Exercício: Escreva um programa que declare uma variável inteira, atribua um valor inicial, divida essa variável por um número digitado pelo usuário e mostre o resultado da divisão.");
//     let num = 20;
//     entrada = parseInt(prompt(`Temos ${num}. Por qual número você quer dividi-lo?`));
//     num /= entrada;
//     alert(`Com o valor que você escolheu, teremos: ${num}`);
// }
function atribuicao05() {
    const num = 20; // Valor inicial da variável

    // ETAPA 3: Mostrar o resultado final
    const mostrarResultado = (resultado) => {
        showCustomAlert({
            title: "Resultado",
            body: `Com o valor que você escolheu, teremos: ${resultado}`
            // Nenhum input, nenhum callback. Apenas mostra a informação.
        });
    };

    // ETAPA 2: Pedir o número ao usuário
    const pedirNumero = () => {
        showCustomAlert({
            title: "Operadores de Atribuição",
            body: `Temos ${num}. Por qual número você quer dividi-lo?`,
            showInput: true, // Mostra o campo de input!
            callback: (valorDigitado) => {
                const entrada = parseInt(valorDigitado);

                if (isNaN(entrada) || entrada === 0) {
                    // Mostra um modal de erro
                    showCustomAlert({
                        title: "Erro",
                        body: "Por favor, digite um número válido e diferente de zero.",
                        callback: pedirNumero // Ao clicar OK no erro, pede o número novamente
                    });
                    return;
                }

                const resultado = num / entrada;
                mostrarResultado(resultado); // Vai para a etapa 3
            }
        });
    };

    // ETAPA 1: Mostrar o enunciado
    const mostrarEnunciado = () => {
        showCustomAlert({
            title: "Operadores de Atribuição",
            body: "Exercício: Escreva um programa que declare uma variável inteira, atribua um valor inicial, divida essa variável por um número digitado pelo usuário e mostre o resultado da divisão.",
            callback: pedirNumero // Ao clicar OK, vai para a etapa 2
        });
    };

    // Inicia a sequência
    mostrarEnunciado();
}


// --- Adicione suas outras funções aqui quando for adaptá-las ---
// Por exemplo:
function aritmeticos01() {
    alert("Esta função ainda usa o alert antigo.");
}
function aritmeticos02() {
    alert("Esta função ainda usa o alert antigo.");
}

// Operadores Relacionais

function relacionais01() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e exiba se eles são iguais ou não.");
    let num1 = parseInt(prompt("Digite o primeiro número:"));
    let num2 = parseInt(prompt("Digite o segundo número:")) ;
    if (num1 === num2) {
        alert(`Os números ${num1} e ${num2} são iguais.`);
    } 
    else {
        alert(`Os números ${num1} e ${num2} não são iguais.`);
    }
}
function relacionais02() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e exiba se eles são diferentes.");
    let num1 = parseInt(prompt("Digite o primeiro número:"));
    let num2 = parseInt(prompt("Digite o segundo número:"));
    if (num1 !== num2) {
        alert(`Os números ${num1} e ${num2} são diferentes.`);
    } 
    else {
        alert(`Os números ${num1} e ${num2} não são diferentes.`);
    }   
}
function relacionais03() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e mostre se o primeiro número é maior que o segundo.");
    let num1 = parseInt(prompt("Digite o primeiro número:"));
    let num2 = parseInt(prompt("Digite o segundo número:"));
    if (num1 > num2) {
        alert(`O número primeiro número (${num1}) é maior que o segundo (${num2}).`);
    } 
    else {
        alert(`O número primeiro número (${num1}) não é maior que o segundo (${num2}).`);
    }
}
function relacionais04() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e exiba se o primeiro número é menor que o segundo.");
    let num1 = parseInt(prompt("Digite o primeiro número:"));
    let num2 = parseInt(prompt("Digite o segundo número:"));
    if (num1 < num2) {
        alert(`O número primeiro número (${num1}) é menor que o segundo (${num2}).`);
    } 
    else {
        alert(`O número primeiro número (${num1}) não é menor que o segundo (${num2}).`);
    }
}
function relacionais05() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e mostre se o primeiro número é maior ou igual ao segundo.");
    let num1 = parseInt(prompt("Digite o primeiro número:"));
    let num2 = parseInt(prompt("Digite o segundo número:"));
    if (num1 > num2) {
        alert(`O número ${num1} é maior que ${num2}.`);
    }
    else if (num1 === num2) {
        alert(`O número ${num1} é igual a ${num2}.`);
    }
    else {
        alert(`O número ${num1} é menor que ${num2}.`);
    }
}

// Operadores Lógicos

function logicos01() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e verifique se ambos são maiores que zero usando o operador lógico &&.");
    let num1 = parseInt(prompt("Digite o primeiro número:"));
    let num2 = parseInt(prompt("Digite o segundo número:"));
    if (num1 > 0 && num2 > 0) {
        alert("Os dois números são maiores que zero.");
    }
    else {
        alert("Pelo menos um dos dois números não é maior que zero.");
    }   
}
function logicos02() {
    alert("Exercício: Escreva um programa que leia dois números inteiros e verifique se pelo menos um deles é menor que zero usando o operador lógico ||.");   
    let num1 = parseInt(prompt("Digite o primeiro número:"));
    let num2 = parseInt(prompt("Digite o segundo número:"));
    if (num1 < 0 || num2 < 0) {
        alert("Pelo menos um dos dois números é menor que zero.");
    }
    else {
        alert("Nenhum dos dois números é menor que zero.");
    }
}

// Operadores Ternários

function ternarios01() {
    alert("Exercício: Escreva um programa que leia a idade de uma pessoa e use o operador ternário para verificar se ela é maior de idade ou não.");
    let idade = parseInt(prompt("Digite sua idade:"));
    let resultado = (idade >= 18) ? "Você é maior de idade." : "Você é menor de idade.";
    alert(resultado);   
}
function ternarios02() {
    alert("Exercício: Escreva um programa que leia um número inteiro e use o operador ternário para verificar se o número é par ou ímpar.");
    let num = parseInt(prompt("Digite um número inteiro:"));
    let resultado = (num % 2 === 0) ? "O número é par." : "O número é ímpar.";
    alert(resultado);
}
function ternarios03() {
    alert('Exercício: Escreva um programa que leia um número inteiro e use o operador ternário para exibir "Positivo" se o número for maior que zero, "Negativo" se o número for menor que zero, e "Zero" se for exatamente zero.');
    let num = parseInt(prompt("Digite um número inteiro:"));
    let resultado = (num > 0) ? "Positivo" : (num < 0) ? "Negativo" : "Zero";
    alert(`O número digitado é: ${resultado}`);
}

