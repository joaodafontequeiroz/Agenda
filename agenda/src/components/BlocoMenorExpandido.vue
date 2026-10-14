<script>

export default{
  data(){
   return{
    adicionar: "+ adicionar tarefa",
    fechar: "fechar",
    titulo: "",
    corpo: "",
    hora: "",
    classe: "",
   }
  },

  emits: ['salva:pagina', 'cancel:task'],

  methods:{
    sendTask(){
      const taskPackage = {
        id: crypto.randomUUID(),
        titulo: this.titulo,
        corpo: this.corpo,
        hora: this.hora,
        classe: this.classe,
        concluido: false,
      }

      this.$emit('salva:pagina', taskPackage);

      this.titulo = "";
      this.corpo = "";
      this.hora = "";
      this.classe = "";
    }
  }
}
</script>

<template>

    <div class="pagina">
      <div class="bloco-menor-expandido">
        <input class="input-titulo" placeholder="Titulo" v-model="titulo">
        <textarea class="input-corpo" placeholder="digite aqui sua atividade" v-model="corpo"></textarea>
        <div class="gap">
          <button class="adicionar" type="button" @click="sendTask">{{ adicionar }}</button>
          <button class="fechar" type="button" @click="$emit('cancel:task', true)">{{ fechar }}</button>
          <select class="classe" v-model="classe">
          <option value="" disabled >Selecione o tipo</option>
          <option value="pessoal">pessoal</option>
          <option value="casa">casa</option>
          <option value="trabalho">trabalho</option>
        </select>
        </div>
        <input class="hora" placeholder="00:00" v-model="hora"/>
      </div>
    </div>
</template>

<style scoped>

.pagina {
  display: block;
  min-height: 0;
  width: 100%;
}

.bloco-menor-expandido {
  position: relative;
  width: 100%;
  min-height: 240px;
  box-sizing: border-box;
  padding: 20px;
  background: #eaf7e4;
  border: 1px solid #cfe5c8;
  border-radius: 12px;
  display: flex;
  flex-direction: column;
  gap: 12px;
}

.input-titulo {
  width: calc(100% - 110px);
  min-width: 0;
  box-sizing: border-box;
  padding: 8px 4px;
  font-family: inherit;
  font-size: 1.125rem;
  font-weight: 600;
  text-align: left;
  color: #1f2d1f;
  border: none;
  outline: none;
  background: transparent;
}

.input-corpo {
  width: 100%;
  flex: 1;
  min-height: 90px;
  box-sizing: border-box;
  padding: 12px 14px;
  font-size: 1rem;
  font-family: inherit;
  line-height: 1.5;
  background: #fff;
  border: 1px solid #d5dfd2;
  border-radius: 10px;
  outline: none;
  resize: none;
  overflow-y: auto;
  transition: border-color 0.15s ease, box-shadow 0.15s ease;
}

.input-corpo:focus {
  border-color: #4a7c68;
  box-shadow: 0 0 0 3px rgba(74, 124, 104, 0.18);
}

.hora {
  position: absolute;
  top: 20px;
  right: 20px;
  width: 80px;
  box-sizing: border-box;
  padding: 6px 10px;
  font-family: inherit;
  font-size: 0.9rem;
  font-weight: 600;
  text-align: center;
  color: #1f2d1f;
  background: #fff;
  border: 1px solid #cfe5c8;
  border-radius: 8px;
  outline: none;
  transition: border-color 0.15s ease, box-shadow 0.15s ease;
}

.hora:focus {
  border-color: #4a7c68;
  box-shadow: 0 0 0 3px rgba(74, 124, 104, 0.18);
}

.gap {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  gap: 10px;
}

.adicionar {
  padding: 8px 16px;
  font-family: inherit;
  font-size: 14px;
  color: #fff;
  background: #4a7c68;
  border: 1px solid #4a7c68;
  border-radius: 10px;
  cursor: pointer;
  transition: background-color 0.15s ease;
}

.adicionar:hover {
  background: #3d6858;
}

.fechar {
  padding: 8px 20px;
  font-family: inherit;
  font-size: 14px;
  color: #1f2d1f;
  background: #fff;
  border: 1px solid #ddd;
  border-radius: 10px;
  cursor: pointer;
  transition: border-color 0.15s ease;
}

.fechar:hover {
  border-color: #4a7c68;
}

.classe {
  appearance: none;
  -webkit-appearance: none;
  -moz-appearance: none;
  margin-left: auto;
  padding: 8px 34px 8px 14px;
  font-family: inherit;
  font-size: 14px;
  font-weight: 600;
  color: #1f2d1f;
  background-color: #fff;
  background-image: url("data:image/svg+xml;charset=UTF-8,%3Csvg xmlns='http://www.w3.org/2000/svg' width='12' height='8' viewBox='0 0 12 8'%3E%3Cpath d='M1 1.5l5 5 5-5' fill='none' stroke='%234a7c68' stroke-width='1.8' stroke-linecap='round' stroke-linejoin='round'/%3E%3C/svg%3E");
  background-repeat: no-repeat;
  background-position: right 12px center;
  border: 1px solid #cfe5c8;
  border-radius: 10px;
  outline: none;
  cursor: pointer;
  transition: border-color 0.15s ease, box-shadow 0.15s ease;
}

.classe:invalid,
.classe:has(option[value=""]:checked) {
  color: #7a8a76;
  font-weight: 500;
}

.classe:hover {
  border-color: #4a7c68;
}

.classe:focus {
  border-color: #4a7c68;
  box-shadow: 0 0 0 3px rgba(74, 124, 104, 0.18);
}

</style>
