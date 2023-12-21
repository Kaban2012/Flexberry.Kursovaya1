import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.kursovaya.caption'),
          title: i18n.t('forms.application.sitemap.kursovaya.title'),
          children: [{
            link: 'i-i-s-kursovaya-филиал-l',
            caption: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-филиал-l.caption'),
            title: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-филиал-l.title'),
            icon: 'chart bar',
            children: null
          }, {
            link: 'i-i-s-kursovaya-ответственный-l',
            caption: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-ответственный-l.caption'),
            title: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-ответственный-l.title'),
            icon: 'archive',
            children: null
          }, {
            link: 'i-i-s-kursovaya-пользователь-l',
            caption: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-пользователь-l.caption'),
            title: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-пользователь-l.title'),
            icon: 'briefcase',
            children: null
          }, {
            link: 'i-i-s-kursovaya-модель-l',
            caption: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-модель-l.caption'),
            title: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-модель-l.title'),
            icon: 'chart bar',
            children: null
          }, {
            link: 'i-i-s-kursovaya-тип-l',
            caption: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-тип-l.caption'),
            title: i18n.t('forms.application.sitemap.kursovaya.i-i-s-kursovaya-тип-l.title'),
            icon: 'archive',
            children: null
          }]
        }
      ]
    };
  }),
})