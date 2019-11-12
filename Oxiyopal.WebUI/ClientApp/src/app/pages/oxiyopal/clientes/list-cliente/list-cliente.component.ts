import { Component, OnInit } from '@angular/core';
import { LocalDataSource } from 'ng2-smart-table';

@Component({
  selector: 'ngx-list-cliente',
  templateUrl: './list-cliente.component.html',
  styleUrls: ['./list-cliente.component.scss']
})
export class ListClienteComponent implements OnInit {

  constructor() { }
  settings = {
    actions: {
      columnTitle: 'Actions',
      add: false,
      edit: false,
      delete: false,
      custom: [
        { name: 'viewrecord', title: '<i class="fas fa-paper-plane enviar"></i>' },
        { name: 'editrecord', title: '&nbsp;&nbsp;<i class="fas fa-edit ver"></i>' },
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
      nombre: {
        title: 'Nombre',
        type: 'string',
      },
      telefono: {
        title: 'Telefono',
        type: 'string',
      },
      direccion: {
        title: 'Dirección',
        type: 'string',
      },
      ciudad: {
        title: 'Ciudad',
        type: 'string',
      },
    },
  };
  data = [];
  source: LocalDataSource = new LocalDataSource();
  ngOnInit() {
    this.loadTable();
  }
  loadTable() {
    for (let i = 0; i < 50; i++) {
      this.data.push({
        id: i,
        nombre: 'l' + i,
        telefono: 'a' + i,
        direccion: 'd' + i,
        ciudad : 'c' + i,
      });
    }
    this.source.load(this.data);
  }
  onCustomAction(event) {
    switch (event.action) {
      case 'viewrecord':
        /// Ver
        break;
      case 'editrecord':
      // Editar
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
        field: 'nombre',
        search: query,
      },
      {
        field: 'telefono',
        search: query,
      },
      {
        field: 'direccion',
        search: query,
      },
      {
        field: 'ciudad',
        search: query,
      },
    ], false);
  }
}
