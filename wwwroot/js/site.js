
// Toggle languages section on Code page

const buttonLanguages = document.getElementById("seeLanguages");

buttonLanguages.addEventListener('click', function() {
    const languages = document.getElementById('Section1_languages')
    
    if (languages.classList.contains('d-none')) {
        languages.classList.remove('d-none');
    } else {
        languages.classList.add('d-none');
    }
});


const buttonRelated = document.getElementById("seeRelated");

buttonRelated.addEventListener('click', function() {
    const related = document.getElementById('Section2_relatedTech')

    if (related.classList.contains('d-none')) {
        related.classList.remove('d-none');
    } else {
        related.classList.add('d-none');
    }
});


const buttonLinux = document.getElementById("seeLinux");

buttonLinux.addEventListener('click', function() {
    const linux = document.getElementById('Section3_linux')

    if (linux.classList.contains('d-none')) {
        linux.classList.remove('d-none');
    } else {
        linux.classList.add('d-none');
    }
});
