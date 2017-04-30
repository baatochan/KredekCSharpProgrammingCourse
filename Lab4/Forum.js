// JavaScript source code

$(document).ready(function (event) {

    var comments = [{
        'id': 1,
        'title': 'Jak zrobić Felix Felicis w domu?',
        'text': 'Hilfe, hilfe'
    },
    {
        'id': 2,
        'title': 'Jak zrobić śmierć w płynie?',
        'text': 'Nie lubie mojego belfra'
    }];

    var alchemyComments = [{
        'id': 11,
        'title': 'Felix Felicis',
        'text': 'Szczęście, szczęśliwe'
    },
    {
        'id': 22,
        'title': 'Kiler',
        'text': 'Fajny film'
    }];

    var subjects = [{
        'id': 1,
        'title': 'Szczescia',
        'messages': comments
    },
    {
        'id': 2,
        'title': 'Problemy',
        'text': alchemyComments
    }];

    function initialize() {
        $.each(subjects, function (key, subject) {
            var exampleSubject = $("#exampleSubject").clone();
            exampleSubject.text(subject.title);
            exampleSubject.attr('id', 'talk-' + subject.id);
            exampleSubject.css('display', '');
            exampleSubject.on('click', function (e) {
                e.preventDefault();
                var talkId = $("#talk-" + subject.id).attr('id').substring(5);
                var searchComments = subjects.find(subjectIterator => subjectIterator.id === talkId);
                
            })
            $.each((subject.text), function (text) {
                addNewComment(text);
            })
            $("#exampleSubject").after(exampleSubject);
        });
        
    }

    function addNewComment(comment) {
        var example = $('#exampleComment').clone();
        example.find('h6').text(comment.title);
        example.attr('id', 'msg-' + comment.id);
        example.css('display', '');
        $('#exampleComment').after(example);
    }

    initialize();

    









})