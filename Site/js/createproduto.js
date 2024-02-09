function createProduto(){
 
    const NomeProduto= document.getElementById('NomeProduto').value;
    const Descricao= document.getElementById('Descricao').value;
    const Categoria= document.getElementById('Categoria').value;
    const DisponibilidadeAdocao= document.getElementById('DisponibilidadeAdocao').value;
    const DoadorId= document.getElementById('DoadorId').value;
   
 
const data={
    NomeProduto:NomeProduto,
    Descricao:Descricao,
    Categoria:Categoria,
    DisponibilidadeAdocao:DisponibilidadeAdocao,
    DoadorId:DoadorId,
   
}
console.log(data)
 
debugger
 
fetch('https://localhost:7120/api/Produto/CadastrarProduto' , {
method:'POST',
headers:{
    'Content-Type':'application/json'
},
body: JSON.stringify(data)
 
 
}).then(Response=> {
    if(!Response.ok){
        alert('Erro ao criar Doador');
    }
    alert("Doador criada com sucesso!");
    window.location.href='../index.html';
})
}
    