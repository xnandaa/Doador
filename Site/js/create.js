function createDoador(){
    const Nome= document.getElementById('nome').value;
    const Cidade= document.getElementById('cidade').value;
    const Estado= document.getElementById('estado').value;
    const CEP= document.getElementById('cep').value;
    const Email= document.getElementById('email').value;
    const Telefone= document.getElementById('telefone').value;

    const data={
        Nome : Nome,
        Cidade : Cidade,
        Estado : Estado,
        CEP : CEP,
        Email: Email,
        Telefone:Telefone
    }
    
    console.log(data)

    debugger

fetch('https://localhost:7120/api/Doador/CadastrarDoador',{
    method: 'POST',
    headers:{
        'Content-Type': 'application/json'
    },
    body: JSON.stringify(data)  
}).then(response => {
    if(!response.ok){ 
        alert("Erro ao criar Doador");
    }
    alert("Doador criada com sucesso");
    window.location.href='../index.html';
})
}