(function () {
    var btn_Task01 = document.createElement('button');
    btn_Task01.innerHTML = 'Task 1';
    btn_Task01.onclick = function () {
        task01();
    };

    var btn_Task02 = document.createElement('button');
    btn_Task02.innerHTML = 'Task 2';
    btn_Task02.onclick = function () {
        task02();        
    };

    document.body.appendChild(btn_Task01);
    document.body.appendChild(btn_Task02);
    
} ());