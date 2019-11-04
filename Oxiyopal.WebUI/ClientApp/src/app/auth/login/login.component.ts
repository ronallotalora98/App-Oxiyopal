import { Component, OnInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit, OnDestroy {

  constructor() { }
  rutaImagen: string;
  imagenes: string[] = ['../../../assets/images/imgLogin/bg1.jpg',
    '../../../assets/images/imgLogin/bg2.jpg',
    '../../../assets/images/imgLogin/bg3.jpg'];
  index = 0;
  cambioDeImagen: any;
  ngOnInit() {
    this.rutaImagen = '../../../assets/images/imgLogin/bg1.jpg';

    this.cambioDeImagen = setInterval(() => {
      this.changeImage();
    }, 8000);

  }
  changeImage() {
    document.getElementById('imagen').style.backgroundImage = 'url(' + this.imagenes[this.index] + ')';

    this.index = this.index + 1;

    if (this.index == 3)
      this.index = 0;
  }

  ngOnDestroy() {
    clearInterval(this.cambioDeImagen);
  }

}
