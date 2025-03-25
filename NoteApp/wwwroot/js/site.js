// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

 const AdicionarNota = document.getElementById('AdicionarNota');

const AllNotes = document.getElementById('TodasNotas');
 Const nota = documet.getElementById('notaid');

function CreateNote()
{
    const Nota = document.createElement('article');

    Nota.classList.add('Nota');
    
    AllNotes.appendChild(Nota);
   

}

AdicionarNota.addEventListener('click', CreateNote);



nota.addEventListener('click', () => {
    nota.classList.toggle('expandida');
});






