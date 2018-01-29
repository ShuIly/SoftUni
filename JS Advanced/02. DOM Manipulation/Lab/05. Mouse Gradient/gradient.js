function attachGradientEvents() {
    let clickBox = document.getElementById('gradient');
    clickBox.addEventListener('mousemove', gradientMove);
    clickBox.addEventListener('mouseout', gradientOut);

    function gradientMove(event) {
        let percent = Math.trunc((event.offsetX / (this.clientWidth - 1)) * 100);
        document.getElementById('result').textContent = percent + '%';
    }

    function gradientOut() {
        document.getElementById('result').textContent = '';
    }
}