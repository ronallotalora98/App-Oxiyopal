import { NbMenuItem } from '@nebular/theme';

export const MENU_ITEMS: NbMenuItem[] = [
    {
        title: 'Inicio',
        icon: 'home-outline',
        link: '/oxi/dashboard',
        home: true,
    },
    {
        title: 'Registrar Factura',
        icon: 'edit-2-outline',
        link: '/dashboard',
    },
    {
        title: 'Cilindros',
        group: true,
    },
    {
        title: 'Agregar Cilindro',
        icon: 'plus-square-outline',
        link: '/oxi/new-cilindro',
    },
    {
        title: 'Control Cilindro',
        icon: 'list-outline',
        link: '/oxi/cilindros',
    },
    {
        title: 'Cartera',
        group: true,
    },
    {
        title: 'Agregar Cliente',
        icon: 'person-add-outline',
        link: '/oxi/new-cliente',
    },
    {
        title: 'Actualizar Cartera',
        icon: 'attach-outline',
        link: '/oxi/list-clientes',
    },
];
