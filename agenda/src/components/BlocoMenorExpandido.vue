<script setup>

</script>

<template>
  <div class="overlay">
    <div class="pagina">
      <div class="bloco-menor-expandido">
        <input class="input-titulo">
        <textarea class="input-corpo"></textarea>
      </div>
    </div>
  </div>
</template>

<style scoped>

.overlay{
  position: fixed;
  inset: 0;
  background: rgba(0, 219, 33,0);
  z-index: 1000;

  display: flex;
  justify-content: center;
  align-items: center;

}

.pagina{
  min-height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
}

.bloco-menor-expandido {
  width: 600px;
  height: 400px;
  padding: 20px;
  border: 1px solid #ccc;
  border-radius: 12px;
  background: #fff;

  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 12px;
}

.input-titulo{
  width: 80%;
  padding: 10px 14px;
  font-size: 1.1rem;
  border: 1px solid #ccc;
  border-radius: 8px;

}

.input-corpo {
  width: 80%;
  flex: 1;
  min-height: 0;
  padding: 10px 14px;
  font-size: 1rem;
  font-family: inherit;
  border: 1px solid #ccc;
  border-radius: 8px;

  resize: none;
  overflow-y: auto;
}

</style>
