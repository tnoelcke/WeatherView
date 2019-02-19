import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'

Vue.config.productionTip = false;

const Foo = {template: '<div>foo</div>' };
const Bar = {template: '<div>bar</div>' };

const routes = [
  {path: '/foo', component: Foo},
  {path: '/bar', component: Bar},
  {path: '/', component: App}
];

const router = new VueRouter({
  routes
});

new Vue({
  el: '#app',
  router,
  template: '<App/>',
  components: {App}
});
