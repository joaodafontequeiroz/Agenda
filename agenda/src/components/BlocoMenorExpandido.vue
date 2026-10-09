<script>

export default{
  data(){
   return{
    adicionar: "+ adicionar tarefa",
    fechar: "fechar",
    hora:"00:00",
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
        <input class="hora" type="time"{{ hora }}/>
      </div>
    </div>
</template>

<style scoped>

.hora{
  position: absolute;
  top: 24px;
  right: 24px;
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
  min-height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
}

.bloco-menor-expandido {
  position: relative;
  width: 400px;
  height: 290px;
  box-sizing: border-box;
  padding: 24px;
  background: #eaf7e4;
  border: 1px solid #cfe5c8;
  border-radius: 16px;

  display: flex;
  flex-direction: column;
  gap: 12px;
}

.input-titulo{
  width: calc(100% - 150px);
  box-sizing: border-box;
  padding: 8px 4px;
  font-size: 1.5rem;
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
  padding: 16px 20px;
  font-size: 1.25rem;
  font-family: inherit;
  line-height: 1.5;
  background: #fff;
  border: 1px solid #d5dfd2;
  border-radius: 12px;
  outline: none;
  resize: none;
  overflow-y: auto;
}

.adicionar{
  padding: px px;
  font-family: inherit;
  font-size: 0.95rem;
  color: #fff;
  background: #4a7c68;
  border: 1px solid #4a7c68;
  border-radius: 10px;
  cursor: pointer;

}

.fechar{
   padding: 10px 18px;
  font-family: inherit;
  font-size: 0.95rem;
  color: #1f2d1f;
  background: #fff;
  border: 1px solid #ddd;
  border-radius: 10px;
  cursor: pointer;
}

</style>
