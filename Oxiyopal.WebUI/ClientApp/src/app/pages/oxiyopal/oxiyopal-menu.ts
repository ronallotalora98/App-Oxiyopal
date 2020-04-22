import { NbMenuItem } from '@nebular/theme';

export const MENU_ITEMS: NbMenuItem[] = [
    {
        title: 'General',
        expanded: false,
        children: [
            {
                title: 'Inicio',
                icon: 'home-outline',
                link: '/oxi/dashboard',
                home: true,
            },
            {
                title: 'Top clientes',
                icon: 'award-outline',
                home: true,
            },
            {
                title: 'Ventas',
                icon: 'pricetags-outline',
                home: true,
            },
            {
                title: 'Mi Bodega',
                icon: 'car-outline',
                home: true,
            },
        ],
    },
    // {
    //     title: 'Registrar Factura',
    //     icon: 'edit-2-outline',
    //     link: '/dashboard',
    // },
    {
        title: 'Cilindros',
        group: true,
    },
    {
        title: 'Agregar Cilindro',
        icon: 'plus-square-outline',
        link: '/oxi/cilindros/new-cilindro',
    },
    {
        title: 'Actualizar Cilindros',
        icon: 'list-outline',
        link: '/oxi/cilindros/tipos',
    },
    {
        title: 'Cilindros Por Recoger',
        icon: 'alert-circle-outline',
        home: true,
    },
    {
        title: 'Clientes',
        group: true,
    },
    {
        title: 'Agregar Cliente',
        icon: 'person-add-outline',
        link: '/oxi/clientes/new-cliente',
    },
    {
        title: 'Actualizar Clientes',
        icon: 'attach-outline',
        link: '/oxi/clientes/list-clientes',
    },
    {
        title: 'Cuentas Por Cobrar',
        icon: 'layers-outline',
        link: '/oxi/clientes/list-clientes',
    },
    {
        title: 'Cartera',
        expanded: true,
        children: [
            {
                title: 'Agregar Factura',
                icon: 'file-text-outline',
              },
              {
                title: 'Recibo de Caja',
                icon: 'credit-card-outline',
              },
              {
                title: 'Agregar Control Cilindro',
                icon: 'clipboard-outline',
              },
        ],
    }
];
