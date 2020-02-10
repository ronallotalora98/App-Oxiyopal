import { Component, OnInit } from '@angular/core';
import { LocalDataSource } from 'ng2-smart-table';
import { ActivatedRoute } from '@angular/router';
import { CilindroService } from '../../../../services/cilindro.service';
import { CilindroSearhResultViewModel } from '../../../../models/CilindroViewModel/CilindroSearhResultViewModel';
import { NgxSpinnerService } from 'ngx-spinner';
import { DatePipe } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'ngx-list-cilindros',
  templateUrl: './list-cilindros.component.html',
  styleUrls: ['./list-cilindros.component.scss'],
})
export class ListCilindrosComponent implements OnInit {

  typeCilinder: string;
  filtrarCilindro: string;
  constructor(private activateRoute: ActivatedRoute,
    private cilindroService: CilindroService,
    private spinner: NgxSpinnerService,
    private datePipe: DatePipe,
    private router: Router) { }

  cilindroResult: CilindroSearhResultViewModel;
  ngOnInit() {
    this.activateRoute.params.subscribe(params => {
      this.typeCilinder = params.type;
      this.spinner.show('tableCilinders', {
        fullScreen: false,
      });
      this.cilindroService.GetCilindersForType(this.typeCilinder).subscribe(res => {
        this.cilindroResult = res;
        this.loadTable();
      });
    });
  }
  // <i class="fas fa-paper-plane enviar"></i>
  // &nbsp;&nbsp;<i class="fas fa-edit ver"></i>
  settings = {
    actions: {
      columnTitle: 'Actions',
      add: false,
      edit: false,
      delete: false,
      custom: [
        { name: 'viewrecord', title: '<i class="fas fa-paper-plane enviar"> Ver</i>' },
        { name: 'editrecord', title: '&nbsp;&nbsp;<i class="fas fa-edit ver"> Editar</i>' },
      ],
      position: 'right',
    },
    hideSubHeader: true,
    pager: {
      display: true,
      perPage: 15,
    },
    columns: {
      id: {
        title: 'ID',
        type: 'number',
      },
      serial: {
        title: 'Serial',
        type: 'string',
      },
      ubicacion: {
        title: 'Ubicación',
        type: 'string',
      },
      donde: {
        title: 'Donde',
        type: 'string',
      },
      desde: {
        title: 'Desde',
        type: 'string',
      },
    },
  };
  data = [];
  source: LocalDataSource = new LocalDataSource();

  loadTable() {
    // for (let i = 0; i < 50; i++) {
    //   this.data.push({
    //     id: i,
    //     serial: 'l' + i,
    //     ubicacion: 'a' + i,
    //     donde: 'd' + i,
    //     desde: 'c' + i,
    //   });
    // }
    let aux = '';
    this.cilindroResult.cilindros.forEach(cilinder => {
      if (cilinder.ubicacion.estaEnBodega == true) {
        aux = 'Bodega';
      } else {
        aux = 'Cliente';
      }
      this.data.push({
        id: cilinder.cilindroId,
        serial: cilinder.serial,
        ubicacion: aux,
        donde: cilinder.ubicacion.nombreUbicacion,
        desde: this.datePipe.transform(cilinder.ubicacion.fechaDeTraslado, 'dd-MMM-yyyy'),
      });
    });
    this.source.load(this.data);
    this.spinner.hide('tableCilinders');
  }
  onCustomAction(event) {
    switch (event.action) {
      case 'viewrecord':
        /// Ver
        break;
      case 'editrecord':
        this.router.navigate(['/oxi/edit-cilindro/' + this.typeCilinder, event.data.id]);
    }
  }

  onSearch(query: string = '') {
    // tslint:disable-next-line: triple-equals
    if (query == '') {
      this.source = new LocalDataSource();
      this.source.load(this.data);
      return;
    }
    this.source.setFilter([
      // fields we want to include in the search
      {
        field: 'id',
        search: query,
      },
      {
        field: 'serial',
        search: query,
      },
      {
        field: 'ubicacion',
        search: query,
      },
      {
        field: 'donde',
        search: query,
      },
      {
        field: 'desde',
        search: query,
      },
    ], false);
  }
}
