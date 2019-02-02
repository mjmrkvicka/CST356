var testStudents = {'students': [
    {'id': 12958073, 'email':'student1@oit.edu'},
    {'id': 78463720, 'email':'student2@oit.edu'},
    {'id': 09128473, 'email':'student3@oit.edu'},
    {'id': 39872048, 'email':'student4@oit.edu'},
    {'id': 98759473, 'email':'student5@oit.edu'},
]};

function initializeStudents() {
    displayStudents(testStudents.students);
}

function displayStudents(students) {

    students.forEach(function(student) {
        console.log('id: ' + student.id + ', email: ' + student.email);

        var markup = '<tr><td>' + student.id + 
                     '</td><td>' + student.email + 
                     '</td></tr>'; 

        $('table tbody').append(markup);
    })
}