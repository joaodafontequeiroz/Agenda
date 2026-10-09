<script>

export default{
  data(){
   return{
    adicionar: "+ adicionar tarefa",
    fechar: "fechar",
    hora:"",
   } 
  }
}
</script>

<template>
  
    <div class="pagina">
      <div class="bloco-menor-expandido">
        <input class="input-titulo" placeholder="Titulo">
        <textarea class="input-corpo" placeholder="digite aqui sua atividade"></textarea>
        <div class="gap">
          <button class="adicionar" type="button">{{ adicionar }}</button>
          <button class="fechar" type="button">{{ fechar }}</button>
        </div>
        <input class="hora" placeholder="00:00" v-model="hora"/>
      </div>
    </div>
</template>

<style scoped>

.hora{
  position: absolute;
  top: 20px;
  right: 20px;
  width: fit-content;
  box-sizing: border-box;
  padding: 6px 10px;
  font-family: inherit;
  font-size: 0.9rem;
  font-weight: 600;
  color: #1f2d1f;
  background: #fff;
  border: 1px solid #cfe5c8;
  border-radius: 8px;
  outline: none;
}

.gap{
  display: flex;
  gap: 10px;
}

.pagina{
  display: block;
  min-height: 0;
}

.bloco-menor-expandido {
  position: relative;
  width: 100%;
  height: 240px;
  box-sizing: border-box;
  padding: 20px;
  background: #eaf7e4;
  border: 1px solid #cfe5c8;
  border-radius: 12px;
  display: flex;
  flex-direction: column;
  gap: 12px;
}

.input-titulo{
  width: calc(100% - 150px);
  box-sizing: border-box;
  padding: 8px 4px;
  font-size: 1.125rem;
  font-weight: 600;
  text-align: left;
  border: none;
  outline: none;
  background: transparent;
}

.input-corpo {
  width: 100%;
  flex: 1;                        
  min-height: 0;
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
}

.adicionar{
  padding: 8px 16px;
  font-family: inherit;
  font-size: 14px;
  color: #fff;
  background: #4a7c68;
  border: 1px solid #4a7c68;
  border-radius: 10px;
  cursor: pointer;

}

.fechar{
  padding: 8px 20px;
  font-family: inherit;
  font-size: 14px;
  color: #1f2d1f;
  background: #fff;
  border: 1px solid #ddd;
  border-radius: 10px;
  cursor: pointer;
}

</style>
