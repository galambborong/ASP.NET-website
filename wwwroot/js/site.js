
// Toggle languages section on Code page

const button = document.getElementById("seeLan");

button.addEventListener('click', function() {
    const lan = document.getElementById('Section1_languages')
    
    if (lan.classList.contains('d-none')) {
        lan.classList.remove('d-none');
    } else {
        lan.classList.add('d-none');
    }
});
