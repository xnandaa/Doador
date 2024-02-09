document.addEventListener('DOMContentLoaded', function(){
   
    const doadorLista = document.getElementById('doador-lista');
 
    function renderTable(data){
        doadorLista.innerHTML =" ";
 
        data.forEach(doador => {
            const row = document.createElement('tr');
 
            row.innerHTML = `
                 <td>${doador.doadorId}</td>
                 <td>${doador.DoadorNome}</td>
                 <td>${doador.Cidade}</td>
                 <td>${doador.Estado}</td>
                 <td>${doador.CEP}</td>
                 <td>${doador.Email}</td>
                 <td>${doador.Telefone}</td>
                 
                 <td>
                     <button>Editar</button>
                     <button>Excluir</button>
                </td>    
 
            `;
            doadorLista.appendChild(row);
        })
           
        feachDoador();
    }
    

})
function abrirTelaCreate(){
    window.location.href = 'pages/create.html';
}
function createProduto(){
    window.location.href = 'pages/createproduto.html';
}