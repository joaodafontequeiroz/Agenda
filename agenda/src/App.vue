  <script>
  import CampoCorpo from './components/CampoCorpo.vue';
  import CampoFundo from './components/CampoFundo.vue';
  import CampoTitulo from './components/CampoTitulo.vue';

  export default{
    name: "App",
    props(){
    },
    data(){
      return{
        modelValue: "",
        data: "",
        tema: false,
        corpo: "",
      }

    },
    components:{
          CampoTitulo,
          CampoCorpo,
          CampoFundo,
        },

    methods: {

    },
  }
  </script>

  <template>

  <main>

    <div>
      <CampoTitulo class="titulo"></CampoTitulo>
    </div>

    <div>
      <CampoCorpo class="corpo"></CampoCorpo>
    </div>

    <div>
      <CampoFundo class=""></CampoFundo>
    </div>

  </main>
  </template>

<style scoped>

.titulo {
  position: relative;
  z-index: 1;
  display: block;
  box-sizing: border-box;
  width: min(800px, 100% - 32px);
  margin: 40px auto 0;
  padding: 28px 36px 4px;
  background: var(--folha, #ffffff);
  border: 1px solid var(--borda, #cfe5c8);
  border-bottom: none;
  border-radius: 14px 14px 0 0;
  box-shadow: 0 -2px 12px rgba(0, 0, 0, 0.06);
}

.corpo {
  position: relative;
  z-index: 1;
  display: block;
  box-sizing: border-box;
  width: min(800px, 100% - 32px);
  min-height: 65vh;
  margin: 0 auto 40px;
  padding: 8px 36px 32px;
  background: var(--folha, #ffffff);
  border: 1px solid var(--borda, #cfe5c8);
  border-top: none;
  border-radius: 0 0 14px 14px;
  box-shadow: 0 10px 24px rgba(0, 0, 0, 0.08);
}

.fundo {
  position: fixed;
  inset: 0;
  z-index: 0;
  background: var(--fundo, #f4f8f1);
  transition: background-color 0.25s;
}

</style>

